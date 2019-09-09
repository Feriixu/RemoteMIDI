namespace RemoteMIDI
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxIP = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonConnectClient = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxPort = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxPublicIP = new MetroFramework.Controls.MetroTextBox();
            this.metroPanelConnection = new MetroFramework.Controls.MetroPanel();
            this.metroButtonCopyIP = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonConnectServer = new MetroFramework.Controls.MetroButton();
            this.metroButtonDisconnect = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxConsole = new MetroFramework.Controls.MetroTextBox();
            this.backgroundWorkerReceiveMIDI = new System.ComponentModel.BackgroundWorker();
            this.metroButtonSendTestToSelf = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTextBoxTestVelocity = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxTestNote = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonSendTestToRemote = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroButtonRefreshDeviceList = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxInputDevice = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBoxLoopbackMIDI = new MetroFramework.Controls.MetroCheckBox();
            this.metroPanelConnection.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(23, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "IP:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxIP
            // 
            // 
            // 
            // 
            this.metroTextBoxIP.CustomButton.Image = null;
            this.metroTextBoxIP.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.metroTextBoxIP.CustomButton.Name = "";
            this.metroTextBoxIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxIP.CustomButton.TabIndex = 1;
            this.metroTextBoxIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxIP.CustomButton.UseSelectable = true;
            this.metroTextBoxIP.CustomButton.Visible = false;
            this.metroTextBoxIP.Lines = new string[0];
            this.metroTextBoxIP.Location = new System.Drawing.Point(72, 96);
            this.metroTextBoxIP.MaxLength = 32767;
            this.metroTextBoxIP.Name = "metroTextBoxIP";
            this.metroTextBoxIP.PasswordChar = '\0';
            this.metroTextBoxIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxIP.SelectedText = "";
            this.metroTextBoxIP.SelectionLength = 0;
            this.metroTextBoxIP.SelectionStart = 0;
            this.metroTextBoxIP.ShortcutsEnabled = true;
            this.metroTextBoxIP.Size = new System.Drawing.Size(153, 23);
            this.metroTextBoxIP.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxIP.TabIndex = 1;
            this.metroTextBoxIP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxIP.UseSelectable = true;
            this.metroTextBoxIP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxIP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonConnectClient
            // 
            this.metroButtonConnectClient.Location = new System.Drawing.Point(19, 154);
            this.metroButtonConnectClient.Name = "metroButtonConnectClient";
            this.metroButtonConnectClient.Size = new System.Drawing.Size(100, 23);
            this.metroButtonConnectClient.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButtonConnectClient.TabIndex = 2;
            this.metroButtonConnectClient.Text = "Be Client";
            this.metroButtonConnectClient.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonConnectClient.UseSelectable = true;
            this.metroButtonConnectClient.Click += new System.EventHandler(this.MetroButtonConnectClient_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 129);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Port:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxPort
            // 
            // 
            // 
            // 
            this.metroTextBoxPort.CustomButton.Image = null;
            this.metroTextBoxPort.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.metroTextBoxPort.CustomButton.Name = "";
            this.metroTextBoxPort.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPort.CustomButton.TabIndex = 1;
            this.metroTextBoxPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPort.CustomButton.UseSelectable = true;
            this.metroTextBoxPort.CustomButton.Visible = false;
            this.metroTextBoxPort.Lines = new string[0];
            this.metroTextBoxPort.Location = new System.Drawing.Point(72, 125);
            this.metroTextBoxPort.MaxLength = 32767;
            this.metroTextBoxPort.Name = "metroTextBoxPort";
            this.metroTextBoxPort.PasswordChar = '\0';
            this.metroTextBoxPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPort.SelectedText = "";
            this.metroTextBoxPort.SelectionLength = 0;
            this.metroTextBoxPort.SelectionStart = 0;
            this.metroTextBoxPort.ShortcutsEnabled = true;
            this.metroTextBoxPort.Size = new System.Drawing.Size(153, 23);
            this.metroTextBoxPort.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxPort.TabIndex = 1;
            this.metroTextBoxPort.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxPort.UseSelectable = true;
            this.metroTextBoxPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(14, 41);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(105, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Your public IP is:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxPublicIP
            // 
            // 
            // 
            // 
            this.metroTextBoxPublicIP.CustomButton.Image = null;
            this.metroTextBoxPublicIP.CustomButton.Location = new System.Drawing.Point(67, 1);
            this.metroTextBoxPublicIP.CustomButton.Name = "";
            this.metroTextBoxPublicIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPublicIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPublicIP.CustomButton.TabIndex = 1;
            this.metroTextBoxPublicIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPublicIP.CustomButton.UseSelectable = true;
            this.metroTextBoxPublicIP.CustomButton.Visible = false;
            this.metroTextBoxPublicIP.Lines = new string[] {
        "255.255.255.255"};
            this.metroTextBoxPublicIP.Location = new System.Drawing.Point(19, 67);
            this.metroTextBoxPublicIP.MaxLength = 32767;
            this.metroTextBoxPublicIP.Name = "metroTextBoxPublicIP";
            this.metroTextBoxPublicIP.PasswordChar = '\0';
            this.metroTextBoxPublicIP.ReadOnly = true;
            this.metroTextBoxPublicIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPublicIP.SelectedText = "";
            this.metroTextBoxPublicIP.SelectionLength = 0;
            this.metroTextBoxPublicIP.SelectionStart = 0;
            this.metroTextBoxPublicIP.ShortcutsEnabled = true;
            this.metroTextBoxPublicIP.Size = new System.Drawing.Size(89, 23);
            this.metroTextBoxPublicIP.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxPublicIP.TabIndex = 1;
            this.metroTextBoxPublicIP.Text = "255.255.255.255";
            this.metroTextBoxPublicIP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxPublicIP.UseSelectable = true;
            this.metroTextBoxPublicIP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPublicIP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanelConnection
            // 
            this.metroPanelConnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanelConnection.Controls.Add(this.metroButtonCopyIP);
            this.metroPanelConnection.Controls.Add(this.metroLabel4);
            this.metroPanelConnection.Controls.Add(this.metroButtonConnectServer);
            this.metroPanelConnection.Controls.Add(this.metroButtonConnectClient);
            this.metroPanelConnection.Controls.Add(this.metroTextBoxPublicIP);
            this.metroPanelConnection.Controls.Add(this.metroButtonDisconnect);
            this.metroPanelConnection.Controls.Add(this.metroLabel3);
            this.metroPanelConnection.Controls.Add(this.metroTextBoxIP);
            this.metroPanelConnection.Controls.Add(this.metroLabel2);
            this.metroPanelConnection.Controls.Add(this.metroLabel1);
            this.metroPanelConnection.Controls.Add(this.metroTextBoxPort);
            this.metroPanelConnection.HorizontalScrollbarBarColor = true;
            this.metroPanelConnection.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelConnection.HorizontalScrollbarSize = 10;
            this.metroPanelConnection.Location = new System.Drawing.Point(23, 63);
            this.metroPanelConnection.Name = "metroPanelConnection";
            this.metroPanelConnection.Size = new System.Drawing.Size(247, 225);
            this.metroPanelConnection.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroPanelConnection.TabIndex = 3;
            this.metroPanelConnection.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelConnection.VerticalScrollbarBarColor = true;
            this.metroPanelConnection.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelConnection.VerticalScrollbarSize = 10;
            // 
            // metroButtonCopyIP
            // 
            this.metroButtonCopyIP.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.metroButtonCopyIP.Location = new System.Drawing.Point(114, 67);
            this.metroButtonCopyIP.Name = "metroButtonCopyIP";
            this.metroButtonCopyIP.Size = new System.Drawing.Size(111, 23);
            this.metroButtonCopyIP.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButtonCopyIP.TabIndex = 12;
            this.metroButtonCopyIP.Text = "COPY";
            this.metroButtonCopyIP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonCopyIP.UseSelectable = true;
            this.metroButtonCopyIP.Click += new System.EventHandler(this.MetroButtonCopyIP_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(12, 7);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(109, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Connection";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButtonConnectServer
            // 
            this.metroButtonConnectServer.Location = new System.Drawing.Point(126, 154);
            this.metroButtonConnectServer.Name = "metroButtonConnectServer";
            this.metroButtonConnectServer.Size = new System.Drawing.Size(99, 23);
            this.metroButtonConnectServer.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButtonConnectServer.TabIndex = 2;
            this.metroButtonConnectServer.Text = "Be Server";
            this.metroButtonConnectServer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonConnectServer.UseSelectable = true;
            this.metroButtonConnectServer.Click += new System.EventHandler(this.MetroButtonConnectServer_Click);
            // 
            // metroButtonDisconnect
            // 
            this.metroButtonDisconnect.Location = new System.Drawing.Point(19, 183);
            this.metroButtonDisconnect.Name = "metroButtonDisconnect";
            this.metroButtonDisconnect.Size = new System.Drawing.Size(206, 23);
            this.metroButtonDisconnect.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButtonDisconnect.TabIndex = 2;
            this.metroButtonDisconnect.Text = "Disconnect";
            this.metroButtonDisconnect.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonDisconnect.UseSelectable = true;
            this.metroButtonDisconnect.Click += new System.EventHandler(this.MetroButtonDisconnect_Click);
            // 
            // metroTextBoxConsole
            // 
            // 
            // 
            // 
            this.metroTextBoxConsole.CustomButton.Image = null;
            this.metroTextBoxConsole.CustomButton.Location = new System.Drawing.Point(582, 1);
            this.metroTextBoxConsole.CustomButton.Name = "";
            this.metroTextBoxConsole.CustomButton.Size = new System.Drawing.Size(171, 171);
            this.metroTextBoxConsole.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxConsole.CustomButton.TabIndex = 1;
            this.metroTextBoxConsole.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxConsole.CustomButton.UseSelectable = true;
            this.metroTextBoxConsole.CustomButton.Visible = false;
            this.metroTextBoxConsole.Lines = new string[0];
            this.metroTextBoxConsole.Location = new System.Drawing.Point(23, 294);
            this.metroTextBoxConsole.MaxLength = 32767;
            this.metroTextBoxConsole.Multiline = true;
            this.metroTextBoxConsole.Name = "metroTextBoxConsole";
            this.metroTextBoxConsole.PasswordChar = '\0';
            this.metroTextBoxConsole.ReadOnly = true;
            this.metroTextBoxConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroTextBoxConsole.SelectedText = "";
            this.metroTextBoxConsole.SelectionLength = 0;
            this.metroTextBoxConsole.SelectionStart = 0;
            this.metroTextBoxConsole.ShortcutsEnabled = true;
            this.metroTextBoxConsole.Size = new System.Drawing.Size(754, 173);
            this.metroTextBoxConsole.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxConsole.TabIndex = 4;
            this.metroTextBoxConsole.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxConsole.UseSelectable = true;
            this.metroTextBoxConsole.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxConsole.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // backgroundWorkerReceiveMIDI
            // 
            this.backgroundWorkerReceiveMIDI.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerReceiveMIDI_DoWork);
            // 
            // metroButtonSendTestToSelf
            // 
            this.metroButtonSendTestToSelf.Location = new System.Drawing.Point(21, 114);
            this.metroButtonSendTestToSelf.Name = "metroButtonSendTestToSelf";
            this.metroButtonSendTestToSelf.Size = new System.Drawing.Size(154, 23);
            this.metroButtonSendTestToSelf.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButtonSendTestToSelf.TabIndex = 5;
            this.metroButtonSendTestToSelf.Text = "Send to self";
            this.metroButtonSendTestToSelf.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonSendTestToSelf.UseSelectable = true;
            this.metroButtonSendTestToSelf.Click += new System.EventHandler(this.MetroButtonSendTestToSelf_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroTextBoxTestVelocity);
            this.metroPanel1.Controls.Add(this.metroTextBoxTestNote);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroButtonSendTestToRemote);
            this.metroPanel1.Controls.Add(this.metroButtonSendTestToSelf);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(577, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 225);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTextBoxTestVelocity
            // 
            // 
            // 
            // 
            this.metroTextBoxTestVelocity.CustomButton.Image = null;
            this.metroTextBoxTestVelocity.CustomButton.Location = new System.Drawing.Point(57, 1);
            this.metroTextBoxTestVelocity.CustomButton.Name = "";
            this.metroTextBoxTestVelocity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxTestVelocity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTestVelocity.CustomButton.TabIndex = 1;
            this.metroTextBoxTestVelocity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTestVelocity.CustomButton.UseSelectable = true;
            this.metroTextBoxTestVelocity.CustomButton.Visible = false;
            this.metroTextBoxTestVelocity.Lines = new string[] {
        "127"};
            this.metroTextBoxTestVelocity.Location = new System.Drawing.Point(96, 85);
            this.metroTextBoxTestVelocity.MaxLength = 32767;
            this.metroTextBoxTestVelocity.Name = "metroTextBoxTestVelocity";
            this.metroTextBoxTestVelocity.PasswordChar = '\0';
            this.metroTextBoxTestVelocity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTestVelocity.SelectedText = "";
            this.metroTextBoxTestVelocity.SelectionLength = 0;
            this.metroTextBoxTestVelocity.SelectionStart = 0;
            this.metroTextBoxTestVelocity.ShortcutsEnabled = true;
            this.metroTextBoxTestVelocity.Size = new System.Drawing.Size(79, 23);
            this.metroTextBoxTestVelocity.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxTestVelocity.TabIndex = 10;
            this.metroTextBoxTestVelocity.Text = "127";
            this.metroTextBoxTestVelocity.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxTestVelocity.UseSelectable = true;
            this.metroTextBoxTestVelocity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxTestVelocity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxTestNote
            // 
            // 
            // 
            // 
            this.metroTextBoxTestNote.CustomButton.Image = null;
            this.metroTextBoxTestNote.CustomButton.Location = new System.Drawing.Point(57, 1);
            this.metroTextBoxTestNote.CustomButton.Name = "";
            this.metroTextBoxTestNote.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxTestNote.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTestNote.CustomButton.TabIndex = 1;
            this.metroTextBoxTestNote.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTestNote.CustomButton.UseSelectable = true;
            this.metroTextBoxTestNote.CustomButton.Visible = false;
            this.metroTextBoxTestNote.Lines = new string[] {
        "48"};
            this.metroTextBoxTestNote.Location = new System.Drawing.Point(96, 56);
            this.metroTextBoxTestNote.MaxLength = 32767;
            this.metroTextBoxTestNote.Name = "metroTextBoxTestNote";
            this.metroTextBoxTestNote.PasswordChar = '\0';
            this.metroTextBoxTestNote.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTestNote.SelectedText = "";
            this.metroTextBoxTestNote.SelectionLength = 0;
            this.metroTextBoxTestNote.SelectionStart = 0;
            this.metroTextBoxTestNote.ShortcutsEnabled = true;
            this.metroTextBoxTestNote.Size = new System.Drawing.Size(79, 23);
            this.metroTextBoxTestNote.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxTestNote.TabIndex = 10;
            this.metroTextBoxTestNote.Text = "48";
            this.metroTextBoxTestNote.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxTestNote.UseSelectable = true;
            this.metroTextBoxTestNote.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxTestNote.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(21, 16);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(46, 25);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel7.TabIndex = 5;
            this.metroLabel7.Text = "Test";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(21, 85);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(56, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Velocity:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(21, 56);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(41, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Note:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButtonSendTestToRemote
            // 
            this.metroButtonSendTestToRemote.Location = new System.Drawing.Point(21, 143);
            this.metroButtonSendTestToRemote.Name = "metroButtonSendTestToRemote";
            this.metroButtonSendTestToRemote.Size = new System.Drawing.Size(154, 23);
            this.metroButtonSendTestToRemote.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButtonSendTestToRemote.TabIndex = 5;
            this.metroButtonSendTestToRemote.Text = "Send to remote";
            this.metroButtonSendTestToRemote.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonSendTestToRemote.UseSelectable = true;
            this.metroButtonSendTestToRemote.Click += new System.EventHandler(this.MetroButtonSendTestToRemote_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.metroCheckBoxLoopbackMIDI);
            this.metroPanel2.Controls.Add(this.metroButtonRefreshDeviceList);
            this.metroPanel2.Controls.Add(this.metroLabel9);
            this.metroPanel2.Controls.Add(this.metroComboBoxInputDevice);
            this.metroPanel2.Controls.Add(this.metroLabel8);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(276, 63);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(295, 225);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroPanel2.TabIndex = 11;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroButtonRefreshDeviceList
            // 
            this.metroButtonRefreshDeviceList.Location = new System.Drawing.Point(109, 102);
            this.metroButtonRefreshDeviceList.Name = "metroButtonRefreshDeviceList";
            this.metroButtonRefreshDeviceList.Size = new System.Drawing.Size(169, 23);
            this.metroButtonRefreshDeviceList.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButtonRefreshDeviceList.TabIndex = 12;
            this.metroButtonRefreshDeviceList.Text = "Refresh device list";
            this.metroButtonRefreshDeviceList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonRefreshDeviceList.UseSelectable = true;
            this.metroButtonRefreshDeviceList.Click += new System.EventHandler(this.RefreshDevices);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(21, 71);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(82, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel9.TabIndex = 11;
            this.metroLabel9.Text = "Input device:";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroComboBoxInputDevice
            // 
            this.metroComboBoxInputDevice.FormattingEnabled = true;
            this.metroComboBoxInputDevice.ItemHeight = 23;
            this.metroComboBoxInputDevice.Location = new System.Drawing.Point(109, 67);
            this.metroComboBoxInputDevice.Name = "metroComboBoxInputDevice";
            this.metroComboBoxInputDevice.Size = new System.Drawing.Size(169, 29);
            this.metroComboBoxInputDevice.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroComboBoxInputDevice.TabIndex = 6;
            this.metroComboBoxInputDevice.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBoxInputDevice.UseSelectable = true;
            this.metroComboBoxInputDevice.SelectedIndexChanged += new System.EventHandler(this.MetroComboBoxInputDevice_SelectedIndexChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(21, 16);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(105, 25);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel8.TabIndex = 5;
            this.metroLabel8.Text = "Input MIDI";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroCheckBoxLoopbackMIDI
            // 
            this.metroCheckBoxLoopbackMIDI.AutoSize = true;
            this.metroCheckBoxLoopbackMIDI.Location = new System.Drawing.Point(21, 143);
            this.metroCheckBoxLoopbackMIDI.Name = "metroCheckBoxLoopbackMIDI";
            this.metroCheckBoxLoopbackMIDI.Size = new System.Drawing.Size(238, 15);
            this.metroCheckBoxLoopbackMIDI.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroCheckBoxLoopbackMIDI.TabIndex = 13;
            this.metroCheckBoxLoopbackMIDI.Text = "Also send MIDI to local RemoteMIDI port";
            this.metroCheckBoxLoopbackMIDI.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxLoopbackMIDI.UseSelectable = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroTextBoxConsole);
            this.Controls.Add(this.metroPanelConnection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Remote MIDI";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelConnection.ResumeLayout(false);
            this.metroPanelConnection.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxIP;
        private MetroFramework.Controls.MetroButton metroButtonConnectClient;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPort;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPublicIP;
        private MetroFramework.Controls.MetroPanel metroPanelConnection;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBoxConsole;
        private MetroFramework.Controls.MetroButton metroButtonConnectServer;
        private System.ComponentModel.BackgroundWorker backgroundWorkerReceiveMIDI;
        private MetroFramework.Controls.MetroButton metroButtonSendTestToSelf;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTestVelocity;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTestNote;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton metroButtonSendTestToRemote;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroComboBox metroComboBoxInputDevice;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton metroButtonCopyIP;
        private MetroFramework.Controls.MetroButton metroButtonDisconnect;
        private MetroFramework.Controls.MetroButton metroButtonRefreshDeviceList;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxLoopbackMIDI;
    }
}