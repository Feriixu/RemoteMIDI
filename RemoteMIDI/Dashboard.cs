using System;
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

        private void Log(string message)
        {
            metroTextBoxConsole.Text += $"[{DateTime.Now.ToString()}] {message}" + Environment.NewLine;
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

            this.metroLabelNumberOfDevices.Text = InputPort.InputCount.ToString();
            for (uint i = 0; i < InputPort.InputCount; i++)
            {
                MIDIINCAPS caps2 = new MIDIINCAPS();
                InputPort.GetDeviceInfo(i, ref caps2, (uint)Marshal.SizeOf(typeof(MIDIINCAPS)));
                metroComboBoxInputDevice.Items.Add(caps2.szPname);
            }
            metroComboBoxInputDevice.SelectedIndex = 0;
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
                MessageBox.Show("Invalid IP address!");
                Log("Invalid input detected!");
                return;
            }
            if (int.TryParse(this.metroTextBoxPort.Text, out var remotePort))
            {
                if (remotePort < 49152 || remotePort > 65535)
                {
                    MessageBox.Show("Invalid Port! Range: 49152 - 65535");
                    Log("Invalid input detected!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid Port!");
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
                MessageBox.Show("Connected!");
            }
            catch (Exception ex)
            {
                Log("Error while connecting!");
                MessageBox.Show(ex.Message);
            }
        }
        private void MetroButtonConnectServer_Click(object sender, EventArgs e)
        {
            Log("Validating inputs ...");

            if (!IPAddress.TryParse(this.metroTextBoxIP.Text, out var remoteIP))
            {
                MessageBox.Show("Invalid IP address!");
                Log("Invalid input detected!");
                return;
            }
            if (int.TryParse(this.metroTextBoxPort.Text, out var remotePort))
            {
                if (remotePort < 49152 || remotePort > 65535)
                {
                    MessageBox.Show("Invalid Port! Range: 49152 - 65535");
                    Log("Invalid input detected!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid Port!");
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
                MessageBox.Show("Connected!");
            }
            catch (Exception ex)
            {
                Log("Error while connecting!");
                MessageBox.Show(ex.Message);
            }
        }
        private void BackgroundWorkerReceiveMIDI_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                var buffer = new byte[3];
                stream.Read(buffer, 0, buffer.Length);
                this.vMIDI.sendCommand(buffer); 
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
            Thread.Sleep(500);
            testData = new byte[]
            {
                0x80,
                Convert.ToByte(this.metroTextBoxTestNote.Text),
                Convert.ToByte(this.metroTextBoxTestVelocity.Text)
            };
            stream.Write(testData, 0, testData.Length);
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

            }
            else
            {
                inputPort = new InputPort();
                inputPort.MIDIInputReceived += MIDIInputReceived;
            }

            Log("Opening port ...");
            inputPort.Open(metroComboBoxInputDevice.SelectedIndex);
            Log("Starting port ...");
            inputPort.Start();
            Log("Device change done!");
        }

        private void MIDIInputReceived(object sender, MIDIMessage e)
        {
            Log("Received local MIDI data!");
            if (client.Connected)
            {
                Log("Sending data ...");
                try
                {
                    stream.Write(e.Data, 0, e.Data.Length);
                    Log("Sent data!");
                }
                catch (Exception ex)
                {
                    Log("Couldn't send data! " + ex.Message);
                }
            }
        }
    }
}
