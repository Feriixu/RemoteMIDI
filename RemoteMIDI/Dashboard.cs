﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using TobiasErichsen.teVirtualMIDI;

namespace RemoteMIDI
{
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        private const int DefaultPort = 63000;
        private const string vMIDIPortName = "RemoteMIDI";
        private readonly TeVirtualMIDI vMIDI;
        private TcpClient client;
        private NetworkStream stream;
        private InputPort inputPort;


        private delegate void SafeLogDelegate(string text);
        private void Log(string message)
        {
            if (metroTextBoxConsole.InvokeRequired)
            {
                var d = new SafeLogDelegate(Log);
                metroTextBoxConsole.Invoke(d, new object[] { message });
            }
            else
            {
                metroTextBoxConsole.AppendText($"[{DateTime.Now.ToString()}] {message}" + Environment.NewLine);
            }
        }

        public Dashboard()
        {
            this.InitializeComponent();
            Log("Trying to create MIDI Interface ...");
            try
            {
                this.vMIDI = new TeVirtualMIDI(vMIDIPortName);
                Log($"Created MIDI Interface {vMIDIPortName}");
            }
            catch (Exception ex)
            {
                this.vMIDI = new TeVirtualMIDI(vMIDIPortName + "Duplicate");
                Log($"Created MIDI Interface {vMIDIPortName + "Duplicate"}");
            }

            Log("Trying to get own IP from http://icanhazip.com ...");
            try
            {
                var externalip = new WebClient().DownloadString("http://icanhazip.com");
                this.metroTextBoxPublicIP.Text = externalip;
                Log($"IP is: {externalip}");
            }
            catch (Exception)
            {
                this.metroTextBoxPublicIP.Text = "Can't get IP";
                Log("Failed to get IP");
            }

            this.RefreshDevices(this, null);
            this.metroTextBoxPort.Text = DefaultPort.ToString();
        }
        ~Dashboard()
        {
            this.vMIDI.shutdown();
            this.client.Close();
            this.stream.Close();
        }

        private void MetroButtonConnectClient_Click(object sender, EventArgs e)
        {
            Log("Validating inputs ...");
            if (!IPAddress.TryParse(this.metroTextBoxIP.Text, out var remoteIP))
            {
                MessageBox.Show("Invalid IP address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Log("Invalid input detected!");
                return;
            }
            if (int.TryParse(this.metroTextBoxPort.Text, out var remotePort))
            {
                if (remotePort < 49152 || remotePort > 65535)
                {
                    MessageBox.Show("Invalid Port! Range: 49152 - 65535", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Log("Invalid input detected!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid Port!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Log("Invalid input detected!");
                return;
            }

            Log("Input OK");
            Log("Trying to connect ...");
            this.client = new TcpClient();
            try
            {
                // Connect
                this.client.Connect(remoteIP, remotePort);
                this.stream = this.client.GetStream();
                this.backgroundWorkerReceiveMIDI.RunWorkerAsync();
                Log("Connected successfully!");
                MessageBox.Show("Connected!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Log("Error while connecting!");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MetroButtonConnectServer_Click(object sender, EventArgs e)
        {
            Log("Validating inputs ...");

            if (int.TryParse(this.metroTextBoxPort.Text, out var remotePort))
            {
                if (remotePort < 49152 || remotePort > 65535)
                {
                    MessageBox.Show("Invalid Port! Range: 49152 - 65535", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log("Invalid input detected!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid Port!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log("Invalid input detected!");
                return;
            }

            Log("Listening for incoming connection ...");
            var listener = new TcpListener(IPAddress.Any, remotePort);
            try
            {
                // Connect
                listener.Start();
                this.client = listener.AcceptTcpClient();
                this.stream = this.client.GetStream();
                this.backgroundWorkerReceiveMIDI.RunWorkerAsync();
                Log("Connected successfully!");
                MessageBox.Show("Connected!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Log("Error while connecting!");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BackgroundWorkerReceiveMIDI_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                try
                {
                    var buffer = new byte[3];
                    stream.Read(buffer, 0, buffer.Length);
                    this.vMIDI.sendCommand(buffer);

                }
                catch (Exception ex)
                {
                    client.Close();
                    stream.Close();
                    MessageBox.Show("Connection lost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void MetroButtonSendTestToSelf_Click(object sender, EventArgs e)
        {
            Log("Validating inputs ...");
            if (!CheckTestInput())
                return;
            Log("Inputs OK");
            Log("Sending test data to MIDI interface ...");
            // If everything ok
            var testData = new byte[]
            {
                0x90,
                Convert.ToByte(this.metroTextBoxTestNote.Text),
                Convert.ToByte(this.metroTextBoxTestVelocity.Text)
            };
            this.vMIDI.sendCommand(testData);
            Thread.Sleep(500);
            testData = new byte[]
            {
                0x80,
                Convert.ToByte(this.metroTextBoxTestNote.Text),
                Convert.ToByte(this.metroTextBoxTestVelocity.Text)
            };
            this.vMIDI.sendCommand(testData);

            Log("Data sent!");
        }
        private void MetroButtonSendTestToRemote_Click(object sender, EventArgs e)
        {
            Log("Validating inputs ...");
            if (!CheckTestInput())
                return;

            Log("Inputs OK");
            Log("Sending test data to remote interface ...");
            // If everything ok
            var testData = new byte[]
            {
                0x90,
                Convert.ToByte(this.metroTextBoxTestNote.Text),
                Convert.ToByte(this.metroTextBoxTestVelocity.Text)
            };
            stream.Write(testData, 0, testData.Length);
            stream.Flush();
            Thread.Sleep(500);
            testData = new byte[]
            {
                0x80,
                Convert.ToByte(this.metroTextBoxTestNote.Text),
                Convert.ToByte(this.metroTextBoxTestVelocity.Text)
            };
            stream.Write(testData, 0, testData.Length);
            stream.Flush();
            Log("Data sent!");
        }
        private bool CheckTestInput()
        {
            var allOK = true;
            if (!int.TryParse(this.metroTextBoxTestNote.Text, out var noteValue))
            {
                SystemSounds.Beep.Play();
                this.metroTextBoxTestNote.Text = "";
                this.metroTextBoxTestNote.WaterMark = "0 - 127";
                this.metroTextBoxTestNote.WaterMarkColor = Color.Red;
                allOK = false;
            }
            else if (noteValue < 0 || noteValue > 0xFF)
            {
                SystemSounds.Beep.Play();
                this.metroTextBoxTestNote.Text = "";
                this.metroTextBoxTestNote.WaterMark = "0 - 127";
                this.metroTextBoxTestNote.WaterMarkColor = Color.Red;
                allOK = false;
            }
            if (!int.TryParse(this.metroTextBoxTestVelocity.Text, out var velValue))
            {
                SystemSounds.Beep.Play();
                this.metroTextBoxTestVelocity.Text = "";
                this.metroTextBoxTestVelocity.WaterMark = "0 - 127";
                this.metroTextBoxTestVelocity.WaterMarkColor = Color.Red;
                allOK = false;
            }
            else if (velValue < 0 || velValue > 0xFF)
            {
                SystemSounds.Beep.Play();
                this.metroTextBoxTestVelocity.Text = "";
                this.metroTextBoxTestVelocity.WaterMark = "0 - 127";
                this.metroTextBoxTestVelocity.WaterMarkColor = Color.Red;
                allOK = false;
            }

            return allOK;
        }
        private void MetroButtonCopyIP_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(metroTextBoxPublicIP.Text);
            Log("Copied public IP to clipboard.");
        }
        private void MetroComboBoxInputDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBoxInputDevice.SelectedIndex == -1)
            {
                return;
            }
            Log("Changing input device ...");

            if (this.inputPort != null)
            {
                // Make sure port is closed and stopped
                if (this.inputPort.Started)
                {
                    Log("Stopping previous port ...");
                    inputPort.Stop();
                }
                if (this.inputPort.Opened)
                {
                    Log("Closing previous port ...");
                    inputPort.Close();
                }
                inputPort = null;
            }
            Log("Creating new input port ...");
            inputPort = new InputPort();
            inputPort.MIDIInputReceived += MIDIInputReceived;
            Log("Input port created.");

            Log("Opening port ...");
            var openResult = inputPort.Open(metroComboBoxInputDevice.SelectedIndex);
            if (openResult)
            {
                Log("Successfully opened port!");
            }
            else
            {
                Log("Error while opening port!");
                this.metroComboBoxInputDevice.SelectedIndex = -1;
                MessageBox.Show("Can't use MIDI device! Is this device already in use by another program?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Log("Starting port ...");
            var startResult = inputPort.Start();
            if (openResult)
            {
                Log("Successfully started listening on port!");
            }
            else
            {
                Log("Error while starting to listen on port!");
                this.metroComboBoxInputDevice.SelectedIndex = -1;
                MessageBox.Show("Can't start listening on MIDI device input! Is this device already in use by another program?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputPort.Close();
                return;
            }

            Log("Device change done!");
        }

        private void MIDIInputReceived(object sender, MIDIMessage e)
        {
            var msgBytes = BitConverter.GetBytes(e.wMsg);
            var param1bytes = BitConverter.GetBytes(e.dwParam1);
            var param2bytes = BitConverter.GetBytes(e.dwParam2);

            var command = param1bytes[0];
            var note = param1bytes[1];
            var velocity = param2bytes[2];


            Log($"Received local MIDI data: 0x{e.dwParam1.ToString("X")}");

            // Loopback MIDI
            if (metroCheckBoxLoopbackMIDI.Checked)
                vMIDI.sendCommand(e.Data);

            // Check if connected
            if (client == null)
                return;
            if (client.Connected)
            {
                // Send data to remote
                Log("Sending data ...");
                try
                {
                    stream.Write(e.Data, 0, e.Data.Length);
                    stream.Flush();
                    Log("Sent data!");
                }
                catch (Exception ex)
                {
                    Log("Couldn't send data! " + ex.Message);
                }
            }
        }

        private void RefreshDevices(object sender, EventArgs e)
        {
            Log("Refreshing device list ...");

            metroComboBoxInputDevice.Items.Clear();

            // Close old port
            if (this.inputPort != null)
            {
                // Make sure port is closed and stopped
                if (this.inputPort.Started)
                {
                    Log("Stopping previous port ...");
                    inputPort.Stop();
                }
                if (this.inputPort.Opened)
                {
                    Log("Closing previous port ...");
                    inputPort.Close();
                }
                inputPort = null;
            }

            for (uint i = 0; i < InputPort.InputCount; i++)
            {
                MIDIINCAPS caps2 = new MIDIINCAPS();
                InputPort.GetDeviceInfo(i, ref caps2, (uint)Marshal.SizeOf(typeof(MIDIINCAPS)));
                metroComboBoxInputDevice.Items.Add(caps2.szPname);
            }
        }

        private void MetroButtonDisconnect_Click(object sender, EventArgs e)
        {

        }
    }
}
