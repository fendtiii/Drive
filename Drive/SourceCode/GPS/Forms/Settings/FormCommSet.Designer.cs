namespace Drive
{

    partial class FormCommSet
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRescan = new System.Windows.Forms.Button();
            this.btnSerialOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxPort = new System.Windows.Forms.ComboBox();
            this.cboxBaud = new System.Windows.Forms.ComboBox();
            this.lblCurrentPort = new System.Windows.Forms.Label();
            this.lblCurrentBaud = new System.Windows.Forms.Label();
            this.btnCloseSerial = new System.Windows.Forms.Button();
            this.textBoxRcv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenSerial = new System.Windows.Forms.Button();
            this.btnCloseSerialArduino = new System.Windows.Forms.Button();
            this.btnOpenSerialArduino = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCurrentArduinoPort = new System.Windows.Forms.Label();
            this.txtBoxRecvArduino = new System.Windows.Forms.TextBox();
            this.cboxArdPort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxSendArduino = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxSendAutoSteer = new System.Windows.Forms.TextBox();
            this.cboxASPort = new System.Windows.Forms.ComboBox();
            this.txtBoxRecvAutoSteer = new System.Windows.Forms.TextBox();
            this.lblCurrentAutoSteerPort = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOpenSerialAutoSteer = new System.Windows.Forms.Button();
            this.btnCloseSerialAutoSteer = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxRcvHeading = new System.Windows.Forms.TextBox();
            this.cboxportheading = new System.Windows.Forms.ComboBox();
            this.cboxbautheading = new System.Windows.Forms.ComboBox();
            this.lblCurrentHeadingPort = new System.Windows.Forms.Label();
            this.lblCurrentHeadingBaud = new System.Windows.Forms.Label();
            this.btnCloseHEADING = new System.Windows.Forms.Button();
            this.btnOpenHEADING = new System.Windows.Forms.Button();
            this.baselineadj = new System.Windows.Forms.NumericUpDown();
            this.headingadj = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baselineadj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headingadj)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRescan
            // 
            this.btnRescan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRescan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRescan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRescan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRescan.Location = new System.Drawing.Point(1217, 610);
            this.btnRescan.Margin = new System.Windows.Forms.Padding(4);
            this.btnRescan.Name = "btnRescan";
            this.btnRescan.Size = new System.Drawing.Size(234, 108);
            this.btnRescan.TabIndex = 58;
            this.btnRescan.Text = "Rescan Ports";
            this.btnRescan.UseVisualStyleBackColor = false;
            this.btnRescan.Click += new System.EventHandler(this.btnRescan_Click);
            // 
            // btnSerialOK
            // 
            this.btnSerialOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerialOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSerialOK.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSerialOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSerialOK.Image = global::Drive.Properties.Resources.OK64;
            this.btnSerialOK.Location = new System.Drawing.Point(1193, 82);
            this.btnSerialOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnSerialOK.Name = "btnSerialOK";
            this.btnSerialOK.Size = new System.Drawing.Size(234, 108);
            this.btnSerialOK.TabIndex = 59;
            this.btnSerialOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSerialOK.UseVisualStyleBackColor = true;
            this.btnSerialOK.Click += new System.EventHandler(this.btnSerialOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cboxPort);
            this.groupBox1.Controls.Add(this.cboxBaud);
            this.groupBox1.Controls.Add(this.lblCurrentPort);
            this.groupBox1.Controls.Add(this.lblCurrentBaud);
            this.groupBox1.Controls.Add(this.btnCloseSerial);
            this.groupBox1.Controls.Add(this.textBoxRcv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOpenSerial);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(18, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1150, 309);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GPS Port";
            // 
            // cboxPort
            // 
            this.cboxPort.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPort.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxPort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxPort.FormattingEnabled = true;
            this.cboxPort.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cboxPort.Location = new System.Drawing.Point(15, 56);
            this.cboxPort.Margin = new System.Windows.Forms.Padding(4);
            this.cboxPort.Name = "cboxPort";
            this.cboxPort.Size = new System.Drawing.Size(252, 51);
            this.cboxPort.TabIndex = 50;
            this.cboxPort.SelectedIndexChanged += new System.EventHandler(this.cboxPort_SelectedIndexChanged_1);
            // 
            // cboxBaud
            // 
            this.cboxBaud.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBaud.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxBaud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxBaud.FormattingEnabled = true;
            this.cboxBaud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cboxBaud.Location = new System.Drawing.Point(297, 56);
            this.cboxBaud.Margin = new System.Windows.Forms.Padding(4);
            this.cboxBaud.Name = "cboxBaud";
            this.cboxBaud.Size = new System.Drawing.Size(188, 51);
            this.cboxBaud.TabIndex = 49;
            this.cboxBaud.SelectedIndexChanged += new System.EventHandler(this.cboxBaud_SelectedIndexChanged_1);
            // 
            // lblCurrentPort
            // 
            this.lblCurrentPort.AutoSize = true;
            this.lblCurrentPort.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPort.Location = new System.Drawing.Point(106, 117);
            this.lblCurrentPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentPort.Name = "lblCurrentPort";
            this.lblCurrentPort.Size = new System.Drawing.Size(61, 28);
            this.lblCurrentPort.TabIndex = 47;
            this.lblCurrentPort.Text = "Port";
            // 
            // lblCurrentBaud
            // 
            this.lblCurrentBaud.AutoSize = true;
            this.lblCurrentBaud.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBaud.Location = new System.Drawing.Point(362, 117);
            this.lblCurrentBaud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentBaud.Name = "lblCurrentBaud";
            this.lblCurrentBaud.Size = new System.Drawing.Size(71, 28);
            this.lblCurrentBaud.TabIndex = 46;
            this.lblCurrentBaud.Text = "Baud";
            // 
            // btnCloseSerial
            // 
            this.btnCloseSerial.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCloseSerial.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCloseSerial.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSerial.Location = new System.Drawing.Point(912, 52);
            this.btnCloseSerial.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseSerial.Name = "btnCloseSerial";
            this.btnCloseSerial.Size = new System.Drawing.Size(207, 60);
            this.btnCloseSerial.TabIndex = 44;
            this.btnCloseSerial.Text = "Disconnect";
            this.btnCloseSerial.UseVisualStyleBackColor = false;
            this.btnCloseSerial.Click += new System.EventHandler(this.btnCloseSerial_Click);
            // 
            // textBoxRcv
            // 
            this.textBoxRcv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRcv.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxRcv.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textBoxRcv.Location = new System.Drawing.Point(15, 184);
            this.textBoxRcv.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxRcv.Multiline = true;
            this.textBoxRcv.Name = "textBoxRcv";
            this.textBoxRcv.ReadOnly = true;
            this.textBoxRcv.Size = new System.Drawing.Size(1102, 110);
            this.textBoxRcv.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(675, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 28);
            this.label1.TabIndex = 41;
            this.label1.Text = "NMEA String";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOpenSerial
            // 
            this.btnOpenSerial.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpenSerial.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenSerial.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSerial.Location = new System.Drawing.Point(687, 52);
            this.btnOpenSerial.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenSerial.Name = "btnOpenSerial";
            this.btnOpenSerial.Size = new System.Drawing.Size(207, 60);
            this.btnOpenSerial.TabIndex = 45;
            this.btnOpenSerial.Text = "Connect";
            this.btnOpenSerial.UseVisualStyleBackColor = false;
            this.btnOpenSerial.Click += new System.EventHandler(this.btnOpenSerial_Click);
            // 
            // btnCloseSerialArduino
            // 
            this.btnCloseSerialArduino.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCloseSerialArduino.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCloseSerialArduino.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSerialArduino.Location = new System.Drawing.Point(852, 36);
            this.btnCloseSerialArduino.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseSerialArduino.Name = "btnCloseSerialArduino";
            this.btnCloseSerialArduino.Size = new System.Drawing.Size(207, 60);
            this.btnCloseSerialArduino.TabIndex = 52;
            this.btnCloseSerialArduino.Text = "Disconnect";
            this.btnCloseSerialArduino.UseVisualStyleBackColor = false;
            this.btnCloseSerialArduino.Click += new System.EventHandler(this.btnCloseSerialArduino_Click);
            // 
            // btnOpenSerialArduino
            // 
            this.btnOpenSerialArduino.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpenSerialArduino.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenSerialArduino.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSerialArduino.Location = new System.Drawing.Point(558, 36);
            this.btnOpenSerialArduino.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenSerialArduino.Name = "btnOpenSerialArduino";
            this.btnOpenSerialArduino.Size = new System.Drawing.Size(207, 60);
            this.btnOpenSerialArduino.TabIndex = 53;
            this.btnOpenSerialArduino.Text = "Connect";
            this.btnOpenSerialArduino.UseVisualStyleBackColor = false;
            this.btnOpenSerialArduino.Click += new System.EventHandler(this.btnOpenSerialArduino_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(567, 124);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(222, 29);
            this.label15.TabIndex = 58;
            this.label15.Text = "From Machine Port:";
            // 
            // lblCurrentArduinoPort
            // 
            this.lblCurrentArduinoPort.AutoSize = true;
            this.lblCurrentArduinoPort.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentArduinoPort.Location = new System.Drawing.Point(234, 60);
            this.lblCurrentArduinoPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentArduinoPort.Name = "lblCurrentArduinoPort";
            this.lblCurrentArduinoPort.Size = new System.Drawing.Size(61, 28);
            this.lblCurrentArduinoPort.TabIndex = 59;
            this.lblCurrentArduinoPort.Text = "Port";
            // 
            // txtBoxRecvArduino
            // 
            this.txtBoxRecvArduino.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxRecvArduino.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtBoxRecvArduino.Location = new System.Drawing.Point(573, 158);
            this.txtBoxRecvArduino.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtBoxRecvArduino.Name = "txtBoxRecvArduino";
            this.txtBoxRecvArduino.ReadOnly = true;
            this.txtBoxRecvArduino.Size = new System.Drawing.Size(478, 36);
            this.txtBoxRecvArduino.TabIndex = 63;
            // 
            // cboxArdPort
            // 
            this.cboxArdPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxArdPort.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxArdPort.FormattingEnabled = true;
            this.cboxArdPort.Location = new System.Drawing.Point(38, 46);
            this.cboxArdPort.Margin = new System.Windows.Forms.Padding(4);
            this.cboxArdPort.Name = "cboxArdPort";
            this.cboxArdPort.Size = new System.Drawing.Size(180, 51);
            this.cboxArdPort.TabIndex = 64;
            this.cboxArdPort.SelectedIndexChanged += new System.EventHandler(this.cboxArdPort_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBoxSendArduino);
            this.groupBox2.Controls.Add(this.cboxArdPort);
            this.groupBox2.Controls.Add(this.txtBoxRecvArduino);
            this.groupBox2.Controls.Add(this.lblCurrentArduinoPort);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btnOpenSerialArduino);
            this.groupBox2.Controls.Add(this.btnCloseSerialArduino);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(18, 829);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1086, 219);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Machine Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 29);
            this.label2.TabIndex = 66;
            this.label2.Text = "To Machine Port:";
            // 
            // txtBoxSendArduino
            // 
            this.txtBoxSendArduino.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxSendArduino.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtBoxSendArduino.Location = new System.Drawing.Point(38, 158);
            this.txtBoxSendArduino.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtBoxSendArduino.Name = "txtBoxSendArduino";
            this.txtBoxSendArduino.ReadOnly = true;
            this.txtBoxSendArduino.Size = new System.Drawing.Size(478, 36);
            this.txtBoxSendArduino.TabIndex = 65;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtBoxSendAutoSteer);
            this.groupBox3.Controls.Add(this.cboxASPort);
            this.groupBox3.Controls.Add(this.txtBoxRecvAutoSteer);
            this.groupBox3.Controls.Add(this.lblCurrentAutoSteerPort);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnOpenSerialAutoSteer);
            this.groupBox3.Controls.Add(this.btnCloseSerialAutoSteer);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(18, 590);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1086, 219);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "AutoSteer Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 29);
            this.label3.TabIndex = 66;
            this.label3.Text = "To Auto Steer:";
            // 
            // txtBoxSendAutoSteer
            // 
            this.txtBoxSendAutoSteer.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxSendAutoSteer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtBoxSendAutoSteer.Location = new System.Drawing.Point(38, 156);
            this.txtBoxSendAutoSteer.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtBoxSendAutoSteer.Name = "txtBoxSendAutoSteer";
            this.txtBoxSendAutoSteer.ReadOnly = true;
            this.txtBoxSendAutoSteer.Size = new System.Drawing.Size(478, 36);
            this.txtBoxSendAutoSteer.TabIndex = 65;
            // 
            // cboxASPort
            // 
            this.cboxASPort.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboxASPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxASPort.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxASPort.FormattingEnabled = true;
            this.cboxASPort.Location = new System.Drawing.Point(38, 46);
            this.cboxASPort.Margin = new System.Windows.Forms.Padding(4);
            this.cboxASPort.Name = "cboxASPort";
            this.cboxASPort.Size = new System.Drawing.Size(180, 51);
            this.cboxASPort.TabIndex = 64;
            this.cboxASPort.SelectedIndexChanged += new System.EventHandler(this.cboxASPort_SelectedIndexChanged);
            // 
            // txtBoxRecvAutoSteer
            // 
            this.txtBoxRecvAutoSteer.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxRecvAutoSteer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtBoxRecvAutoSteer.Location = new System.Drawing.Point(573, 156);
            this.txtBoxRecvAutoSteer.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtBoxRecvAutoSteer.Name = "txtBoxRecvAutoSteer";
            this.txtBoxRecvAutoSteer.ReadOnly = true;
            this.txtBoxRecvAutoSteer.Size = new System.Drawing.Size(478, 36);
            this.txtBoxRecvAutoSteer.TabIndex = 63;
            // 
            // lblCurrentAutoSteerPort
            // 
            this.lblCurrentAutoSteerPort.AutoSize = true;
            this.lblCurrentAutoSteerPort.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAutoSteerPort.Location = new System.Drawing.Point(234, 63);
            this.lblCurrentAutoSteerPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentAutoSteerPort.Name = "lblCurrentAutoSteerPort";
            this.lblCurrentAutoSteerPort.Size = new System.Drawing.Size(61, 28);
            this.lblCurrentAutoSteerPort.TabIndex = 59;
            this.lblCurrentAutoSteerPort.Text = "Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(567, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 29);
            this.label6.TabIndex = 58;
            this.label6.Text = "From Auto Steer:";
            // 
            // btnOpenSerialAutoSteer
            // 
            this.btnOpenSerialAutoSteer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpenSerialAutoSteer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenSerialAutoSteer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSerialAutoSteer.Location = new System.Drawing.Point(558, 36);
            this.btnOpenSerialAutoSteer.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenSerialAutoSteer.Name = "btnOpenSerialAutoSteer";
            this.btnOpenSerialAutoSteer.Size = new System.Drawing.Size(207, 60);
            this.btnOpenSerialAutoSteer.TabIndex = 53;
            this.btnOpenSerialAutoSteer.Text = "Connect";
            this.btnOpenSerialAutoSteer.UseVisualStyleBackColor = false;
            this.btnOpenSerialAutoSteer.Click += new System.EventHandler(this.btnOpenSerialAutoSteer_Click);
            // 
            // btnCloseSerialAutoSteer
            // 
            this.btnCloseSerialAutoSteer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCloseSerialAutoSteer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCloseSerialAutoSteer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSerialAutoSteer.Location = new System.Drawing.Point(840, 36);
            this.btnCloseSerialAutoSteer.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseSerialAutoSteer.Name = "btnCloseSerialAutoSteer";
            this.btnCloseSerialAutoSteer.Size = new System.Drawing.Size(207, 60);
            this.btnCloseSerialAutoSteer.TabIndex = 52;
            this.btnCloseSerialAutoSteer.Text = "Disconnect";
            this.btnCloseSerialAutoSteer.UseVisualStyleBackColor = false;
            this.btnCloseSerialAutoSteer.Click += new System.EventHandler(this.btnCloseSerialAutoSteer_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.textBoxRcvHeading);
            this.groupBox4.Controls.Add(this.cboxportheading);
            this.groupBox4.Controls.Add(this.cboxbautheading);
            this.groupBox4.Controls.Add(this.lblCurrentHeadingPort);
            this.groupBox4.Controls.Add(this.lblCurrentHeadingBaud);
            this.groupBox4.Controls.Add(this.btnCloseHEADING);
            this.groupBox4.Controls.Add(this.btnOpenHEADING);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(18, 348);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1150, 217);
            this.groupBox4.TabIndex = 67;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Heading Port";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // textBoxRcvHeading
            // 
            this.textBoxRcvHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRcvHeading.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxRcvHeading.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textBoxRcvHeading.Location = new System.Drawing.Point(15, 159);
            this.textBoxRcvHeading.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxRcvHeading.Multiline = true;
            this.textBoxRcvHeading.Name = "textBoxRcvHeading";
            this.textBoxRcvHeading.ReadOnly = true;
            this.textBoxRcvHeading.Size = new System.Drawing.Size(1102, 46);
            this.textBoxRcvHeading.TabIndex = 68;
            // 
            // cboxportheading
            // 
            this.cboxportheading.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboxportheading.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxportheading.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxportheading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxportheading.FormattingEnabled = true;
            this.cboxportheading.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cboxportheading.Location = new System.Drawing.Point(15, 56);
            this.cboxportheading.Margin = new System.Windows.Forms.Padding(4);
            this.cboxportheading.Name = "cboxportheading";
            this.cboxportheading.Size = new System.Drawing.Size(252, 51);
            this.cboxportheading.TabIndex = 50;
            this.cboxportheading.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboxbautheading
            // 
            this.cboxbautheading.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboxbautheading.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxbautheading.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxbautheading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxbautheading.FormattingEnabled = true;
            this.cboxbautheading.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cboxbautheading.Location = new System.Drawing.Point(297, 56);
            this.cboxbautheading.Margin = new System.Windows.Forms.Padding(4);
            this.cboxbautheading.Name = "cboxbautheading";
            this.cboxbautheading.Size = new System.Drawing.Size(188, 51);
            this.cboxbautheading.TabIndex = 49;
            this.cboxbautheading.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblCurrentHeadingPort
            // 
            this.lblCurrentHeadingPort.AutoSize = true;
            this.lblCurrentHeadingPort.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentHeadingPort.Location = new System.Drawing.Point(106, 117);
            this.lblCurrentHeadingPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentHeadingPort.Name = "lblCurrentHeadingPort";
            this.lblCurrentHeadingPort.Size = new System.Drawing.Size(61, 28);
            this.lblCurrentHeadingPort.TabIndex = 47;
            this.lblCurrentHeadingPort.Text = "Port";
            // 
            // lblCurrentHeadingBaud
            // 
            this.lblCurrentHeadingBaud.AutoSize = true;
            this.lblCurrentHeadingBaud.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentHeadingBaud.Location = new System.Drawing.Point(362, 117);
            this.lblCurrentHeadingBaud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentHeadingBaud.Name = "lblCurrentHeadingBaud";
            this.lblCurrentHeadingBaud.Size = new System.Drawing.Size(71, 28);
            this.lblCurrentHeadingBaud.TabIndex = 46;
            this.lblCurrentHeadingBaud.Text = "Baud";
            // 
            // btnCloseHEADING
            // 
            this.btnCloseHEADING.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCloseHEADING.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCloseHEADING.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseHEADING.Location = new System.Drawing.Point(912, 52);
            this.btnCloseHEADING.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseHEADING.Name = "btnCloseHEADING";
            this.btnCloseHEADING.Size = new System.Drawing.Size(207, 60);
            this.btnCloseHEADING.TabIndex = 44;
            this.btnCloseHEADING.Text = "Disconnect";
            this.btnCloseHEADING.UseVisualStyleBackColor = false;
            this.btnCloseHEADING.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpenHEADING
            // 
            this.btnOpenHEADING.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpenHEADING.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenHEADING.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenHEADING.Location = new System.Drawing.Point(687, 52);
            this.btnOpenHEADING.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenHEADING.Name = "btnOpenHEADING";
            this.btnOpenHEADING.Size = new System.Drawing.Size(207, 60);
            this.btnOpenHEADING.TabIndex = 45;
            this.btnOpenHEADING.Text = "Connect";
            this.btnOpenHEADING.UseVisualStyleBackColor = false;
            this.btnOpenHEADING.Click += new System.EventHandler(this.button2_Click);
            // 
            // baselineadj
            // 
            this.baselineadj.DecimalPlaces = 2;
            this.baselineadj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baselineadj.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.baselineadj.Location = new System.Drawing.Point(1217, 400);
            this.baselineadj.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.baselineadj.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.baselineadj.Name = "baselineadj";
            this.baselineadj.Size = new System.Drawing.Size(165, 53);
            this.baselineadj.TabIndex = 68;
            this.baselineadj.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.baselineadj.ValueChanged += new System.EventHandler(this.baselineadj_ValueChanged);
            this.baselineadj.Enter += new System.EventHandler(this.baselineadj_Enter);
            // 
            // headingadj
            // 
            this.headingadj.DecimalPlaces = 1;
            this.headingadj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingadj.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.headingadj.Location = new System.Drawing.Point(1217, 507);
            this.headingadj.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.headingadj.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.headingadj.Name = "headingadj";
            this.headingadj.Size = new System.Drawing.Size(165, 53);
            this.headingadj.TabIndex = 69;
            this.headingadj.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.headingadj.Enter += new System.EventHandler(this.headingadj_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1212, 348);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 70;
            this.label4.Text = "Baseline";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1212, 464);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 29);
            this.label5.TabIndex = 71;
            this.label5.Text = "Heading Adj";
            // 
            // FormCommSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1449, 1092);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.headingadj);
            this.Controls.Add(this.baselineadj);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRescan);
            this.Controls.Add(this.btnSerialOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCommSet";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Communication Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormCommSet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baselineadj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headingadj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRescan;
        private System.Windows.Forms.Button btnSerialOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCurrentPort;
        private System.Windows.Forms.Label lblCurrentBaud;
        private System.Windows.Forms.Button btnCloseSerial;
        private System.Windows.Forms.TextBox textBoxRcv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenSerial;
        private System.Windows.Forms.ComboBox cboxBaud;
        private System.Windows.Forms.ComboBox cboxPort;
        private System.Windows.Forms.Button btnCloseSerialArduino;
        private System.Windows.Forms.Button btnOpenSerialArduino;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblCurrentArduinoPort;
        private System.Windows.Forms.TextBox txtBoxRecvArduino;
        private System.Windows.Forms.ComboBox cboxArdPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxSendArduino;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxSendAutoSteer;
        private System.Windows.Forms.ComboBox cboxASPort;
        private System.Windows.Forms.TextBox txtBoxRecvAutoSteer;
        private System.Windows.Forms.Label lblCurrentAutoSteerPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOpenSerialAutoSteer;
        private System.Windows.Forms.Button btnCloseSerialAutoSteer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboxportheading;
        private System.Windows.Forms.ComboBox cboxbautheading;
        private System.Windows.Forms.Label lblCurrentHeadingPort;
        private System.Windows.Forms.Label lblCurrentHeadingBaud;
        private System.Windows.Forms.Button btnCloseHEADING;
        private System.Windows.Forms.Button btnOpenHEADING;
        private System.Windows.Forms.TextBox textBoxRcvHeading;
        private System.Windows.Forms.NumericUpDown baselineadj;
        private System.Windows.Forms.NumericUpDown headingadj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}