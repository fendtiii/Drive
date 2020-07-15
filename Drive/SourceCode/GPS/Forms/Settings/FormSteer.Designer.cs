namespace Drive
{
    partial class FormSteer
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
            this.btnFreeDrive = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGain = new System.Windows.Forms.TabPage();
            this.hsbarHighSteerPWM = new System.Windows.Forms.HScrollBar();
            this.hsbarMinPWM = new System.Windows.Forms.HScrollBar();
            this.hsbarProportionalGain = new System.Windows.Forms.HScrollBar();
            this.label45 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.hsbarLowSteerPWM = new System.Windows.Forms.HScrollBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblMinPWM = new System.Windows.Forms.Label();
            this.lblHighSteerPWM = new System.Windows.Forms.Label();
            this.lblLowSteerPWM = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblProportionalGain = new System.Windows.Forms.Label();
            this.lblPWMDisplay = new System.Windows.Forms.Label();
            this.tabSteer = new System.Windows.Forms.TabPage();
            this.hsbarSidehillDraftGain = new System.Windows.Forms.HScrollBar();
            this.label25 = new System.Windows.Forms.Label();
            this.hsbarCountsPerDegree = new System.Windows.Forms.HScrollBar();
            this.label29 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.hsbarMaxSteerAngle = new System.Windows.Forms.HScrollBar();
            this.label10 = new System.Windows.Forms.Label();
            this.hsbarSteerAngleSensorZero = new System.Windows.Forms.HScrollBar();
            this.lblCountsPerDegree = new System.Windows.Forms.Label();
            this.lblMaxSteerAngle = new System.Windows.Forms.Label();
            this.lblSidehillDraftGain = new System.Windows.Forms.Label();
            this.lblSteerAngleSensorZero = new System.Windows.Forms.Label();
            this.tabStan = new System.Windows.Forms.TabPage();
            this.label27 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.hsbarHeadingErrorGain = new System.Windows.Forms.HScrollBar();
            this.lblStanleyGain = new System.Windows.Forms.Label();
            this.hsbarStanleyGain = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlusTenth = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHeadingErrorGain = new System.Windows.Forms.Label();
            this.btnMinusTenth = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.tabInt = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.nudIntDistance = new System.Windows.Forms.NumericUpDown();
            this.nudIntHeading = new System.Windows.Forms.NumericUpDown();
            this.lblDistanceAway = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblAvgXTE = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.hsbarAvgXTE = new System.Windows.Forms.HScrollBar();
            this.label17 = new System.Windows.Forms.Label();
            this.lblStanleyIntegralGain = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.hsbarIntegralGain = new System.Windows.Forms.HScrollBar();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSteerAngle = new System.Windows.Forms.Label();
            this.lblRecd = new System.Windows.Forms.Label();
            this.lblSent = new System.Windows.Forms.Label();
            this.lblSteerAngleActual = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnFreeDriveZero = new System.Windows.Forms.Button();
            this.btnSteerAngleDown = new ProXoft.WinForms.RepeatButton();
            this.btnSteerAngleUp = new ProXoft.WinForms.RepeatButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnMinus20 = new System.Windows.Forms.Button();
            this.btnPlus20 = new System.Windows.Forms.Button();
            this.pbActPos = new System.Windows.Forms.ProgressBar();
            this.pbActNeg = new System.Windows.Forms.ProgressBar();
            this.pbSetNeg = new System.Windows.Forms.ProgressBar();
            this.pbSetPos = new System.Windows.Forms.ProgressBar();
            this.pbErrNeg = new System.Windows.Forms.ProgressBar();
            this.pbErrPos = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabGain.SuspendLayout();
            this.tabSteer.SuspendLayout();
            this.tabStan.SuspendLayout();
            this.tabInt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntHeading)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFreeDrive
            // 
            this.btnFreeDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFreeDrive.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreeDrive.Location = new System.Drawing.Point(268, 444);
            this.btnFreeDrive.Name = "btnFreeDrive";
            this.btnFreeDrive.Size = new System.Drawing.Size(125, 29);
            this.btnFreeDrive.TabIndex = 228;
            this.btnFreeDrive.Text = "Drive";
            this.btnFreeDrive.UseVisualStyleBackColor = true;
            this.btnFreeDrive.Click += new System.EventHandler(this.btnFreeDrive_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabGain);
            this.tabControl1.Controls.Add(this.tabSteer);
            this.tabControl1.Controls.Add(this.tabStan);
            this.tabControl1.Controls.Add(this.tabInt);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(95, 48);
            this.tabControl1.Location = new System.Drawing.Point(2, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(395, 351);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 232;
            // 
            // tabGain
            // 
            this.tabGain.AutoScroll = true;
            this.tabGain.BackColor = System.Drawing.Color.PowderBlue;
            this.tabGain.Controls.Add(this.hsbarHighSteerPWM);
            this.tabGain.Controls.Add(this.hsbarMinPWM);
            this.tabGain.Controls.Add(this.hsbarProportionalGain);
            this.tabGain.Controls.Add(this.label45);
            this.tabGain.Controls.Add(this.label41);
            this.tabGain.Controls.Add(this.hsbarLowSteerPWM);
            this.tabGain.Controls.Add(this.label7);
            this.tabGain.Controls.Add(this.label33);
            this.tabGain.Controls.Add(this.lblMinPWM);
            this.tabGain.Controls.Add(this.lblHighSteerPWM);
            this.tabGain.Controls.Add(this.lblLowSteerPWM);
            this.tabGain.Controls.Add(this.label9);
            this.tabGain.Controls.Add(this.lblProportionalGain);
            this.tabGain.Controls.Add(this.lblPWMDisplay);
            this.tabGain.Location = new System.Drawing.Point(4, 52);
            this.tabGain.Name = "tabGain";
            this.tabGain.Size = new System.Drawing.Size(387, 295);
            this.tabGain.TabIndex = 13;
            this.tabGain.Text = "Gain";
            // 
            // hsbarHighSteerPWM
            // 
            this.hsbarHighSteerPWM.LargeChange = 2;
            this.hsbarHighSteerPWM.Location = new System.Drawing.Point(12, 154);
            this.hsbarHighSteerPWM.Maximum = 255;
            this.hsbarHighSteerPWM.Minimum = 1;
            this.hsbarHighSteerPWM.Name = "hsbarHighSteerPWM";
            this.hsbarHighSteerPWM.Size = new System.Drawing.Size(260, 30);
            this.hsbarHighSteerPWM.TabIndex = 274;
            this.hsbarHighSteerPWM.Value = 50;
            this.hsbarHighSteerPWM.ValueChanged += new System.EventHandler(this.hsbarHighSteerPWM_ValueChanged);
            // 
            // hsbarMinPWM
            // 
            this.hsbarMinPWM.LargeChange = 1;
            this.hsbarMinPWM.Location = new System.Drawing.Point(14, 93);
            this.hsbarMinPWM.Name = "hsbarMinPWM";
            this.hsbarMinPWM.Size = new System.Drawing.Size(260, 30);
            this.hsbarMinPWM.TabIndex = 284;
            this.hsbarMinPWM.Value = 10;
            this.hsbarMinPWM.ValueChanged += new System.EventHandler(this.hsbarMinPWM_ValueChanged);
            // 
            // hsbarProportionalGain
            // 
            this.hsbarProportionalGain.LargeChange = 1;
            this.hsbarProportionalGain.Location = new System.Drawing.Point(12, 29);
            this.hsbarProportionalGain.Maximum = 200;
            this.hsbarProportionalGain.Name = "hsbarProportionalGain";
            this.hsbarProportionalGain.Size = new System.Drawing.Size(260, 30);
            this.hsbarProportionalGain.TabIndex = 254;
            this.hsbarProportionalGain.Value = 4;
            this.hsbarProportionalGain.ValueChanged += new System.EventHandler(this.hsbarProportionalGain_ValueChanged);
            // 
            // label45
            // 
            this.label45.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(13, 130);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(251, 23);
            this.label45.TabIndex = 275;
            this.label45.Text = "High Max PWM";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            this.label41.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(17, 67);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(247, 23);
            this.label41.TabIndex = 285;
            this.label41.Text = "Minimum PWM Drive";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarLowSteerPWM
            // 
            this.hsbarLowSteerPWM.LargeChange = 1;
            this.hsbarLowSteerPWM.Location = new System.Drawing.Point(14, 219);
            this.hsbarLowSteerPWM.Maximum = 255;
            this.hsbarLowSteerPWM.Minimum = 1;
            this.hsbarLowSteerPWM.Name = "hsbarLowSteerPWM";
            this.hsbarLowSteerPWM.Size = new System.Drawing.Size(260, 30);
            this.hsbarLowSteerPWM.TabIndex = 269;
            this.hsbarLowSteerPWM.Value = 1;
            this.hsbarLowSteerPWM.ValueChanged += new System.EventHandler(this.hsbarLowSteerPWM_ValueChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 23);
            this.label7.TabIndex = 255;
            this.label7.Text = "Proportional Gain";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(12, 195);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(254, 23);
            this.label33.TabIndex = 270;
            this.label33.Text = "Low Max PWM";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinPWM
            // 
            this.lblMinPWM.AutoSize = true;
            this.lblMinPWM.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinPWM.Location = new System.Drawing.Point(279, 87);
            this.lblMinPWM.Name = "lblMinPWM";
            this.lblMinPWM.Size = new System.Drawing.Size(91, 39);
            this.lblMinPWM.TabIndex = 288;
            this.lblMinPWM.Text = "-888";
            // 
            // lblHighSteerPWM
            // 
            this.lblHighSteerPWM.AutoSize = true;
            this.lblHighSteerPWM.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighSteerPWM.Location = new System.Drawing.Point(279, 148);
            this.lblHighSteerPWM.Name = "lblHighSteerPWM";
            this.lblHighSteerPWM.Size = new System.Drawing.Size(91, 39);
            this.lblHighSteerPWM.TabIndex = 278;
            this.lblHighSteerPWM.Text = "-888";
            // 
            // lblLowSteerPWM
            // 
            this.lblLowSteerPWM.AutoSize = true;
            this.lblLowSteerPWM.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowSteerPWM.Location = new System.Drawing.Point(279, 213);
            this.lblLowSteerPWM.Name = "lblLowSteerPWM";
            this.lblLowSteerPWM.Size = new System.Drawing.Size(91, 39);
            this.lblLowSteerPWM.TabIndex = 273;
            this.lblLowSteerPWM.Text = "-888";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(216, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 318;
            this.label9.Text = "PWM:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProportionalGain
            // 
            this.lblProportionalGain.AutoSize = true;
            this.lblProportionalGain.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProportionalGain.Location = new System.Drawing.Point(279, 22);
            this.lblProportionalGain.Name = "lblProportionalGain";
            this.lblProportionalGain.Size = new System.Drawing.Size(91, 39);
            this.lblProportionalGain.TabIndex = 258;
            this.lblProportionalGain.Text = "-888";
            // 
            // lblPWMDisplay
            // 
            this.lblPWMDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblPWMDisplay.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPWMDisplay.Location = new System.Drawing.Point(281, 260);
            this.lblPWMDisplay.Name = "lblPWMDisplay";
            this.lblPWMDisplay.Size = new System.Drawing.Size(89, 32);
            this.lblPWMDisplay.TabIndex = 316;
            this.lblPWMDisplay.Text = "255";
            this.lblPWMDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabSteer
            // 
            this.tabSteer.AutoScroll = true;
            this.tabSteer.BackColor = System.Drawing.Color.PowderBlue;
            this.tabSteer.Controls.Add(this.hsbarSidehillDraftGain);
            this.tabSteer.Controls.Add(this.label25);
            this.tabSteer.Controls.Add(this.hsbarCountsPerDegree);
            this.tabSteer.Controls.Add(this.label29);
            this.tabSteer.Controls.Add(this.label19);
            this.tabSteer.Controls.Add(this.hsbarMaxSteerAngle);
            this.tabSteer.Controls.Add(this.label10);
            this.tabSteer.Controls.Add(this.hsbarSteerAngleSensorZero);
            this.tabSteer.Controls.Add(this.lblCountsPerDegree);
            this.tabSteer.Controls.Add(this.lblMaxSteerAngle);
            this.tabSteer.Controls.Add(this.lblSidehillDraftGain);
            this.tabSteer.Controls.Add(this.lblSteerAngleSensorZero);
            this.tabSteer.Location = new System.Drawing.Point(4, 52);
            this.tabSteer.Name = "tabSteer";
            this.tabSteer.Size = new System.Drawing.Size(387, 295);
            this.tabSteer.TabIndex = 5;
            this.tabSteer.Text = "Steer";
            // 
            // hsbarSidehillDraftGain
            // 
            this.hsbarSidehillDraftGain.LargeChange = 1;
            this.hsbarSidehillDraftGain.Location = new System.Drawing.Point(10, 231);
            this.hsbarSidehillDraftGain.Maximum = 24;
            this.hsbarSidehillDraftGain.Name = "hsbarSidehillDraftGain";
            this.hsbarSidehillDraftGain.Size = new System.Drawing.Size(282, 30);
            this.hsbarSidehillDraftGain.TabIndex = 264;
            this.hsbarSidehillDraftGain.Value = 2;
            this.hsbarSidehillDraftGain.ValueChanged += new System.EventHandler(this.hsbarSidehillDraftGain_ValueChanged);
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(10, 71);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(253, 23);
            this.label25.TabIndex = 305;
            this.label25.Text = "Counts per Degree";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarCountsPerDegree
            // 
            this.hsbarCountsPerDegree.LargeChange = 1;
            this.hsbarCountsPerDegree.Location = new System.Drawing.Point(10, 96);
            this.hsbarCountsPerDegree.Maximum = 255;
            this.hsbarCountsPerDegree.Minimum = 1;
            this.hsbarCountsPerDegree.Name = "hsbarCountsPerDegree";
            this.hsbarCountsPerDegree.Size = new System.Drawing.Size(282, 30);
            this.hsbarCountsPerDegree.TabIndex = 304;
            this.hsbarCountsPerDegree.Value = 20;
            this.hsbarCountsPerDegree.ValueChanged += new System.EventHandler(this.hsbarCountsPerDegree_ValueChanged);
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(12, 206);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(253, 23);
            this.label29.TabIndex = 265;
            this.label29.Text = "Sidehill Draft Gain";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(10, 139);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(253, 23);
            this.label19.TabIndex = 300;
            this.label19.Text = "Max Steer Angle in Degrees";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarMaxSteerAngle
            // 
            this.hsbarMaxSteerAngle.LargeChange = 1;
            this.hsbarMaxSteerAngle.Location = new System.Drawing.Point(10, 164);
            this.hsbarMaxSteerAngle.Maximum = 80;
            this.hsbarMaxSteerAngle.Minimum = 10;
            this.hsbarMaxSteerAngle.Name = "hsbarMaxSteerAngle";
            this.hsbarMaxSteerAngle.Size = new System.Drawing.Size(282, 30);
            this.hsbarMaxSteerAngle.TabIndex = 299;
            this.hsbarMaxSteerAngle.Value = 10;
            this.hsbarMaxSteerAngle.ValueChanged += new System.EventHandler(this.hsbarMaxSteerAngle_ValueChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 23);
            this.label10.TabIndex = 295;
            this.label10.Text = "Wheel Angle Sensor Zero";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarSteerAngleSensorZero
            // 
            this.hsbarSteerAngleSensorZero.LargeChange = 1;
            this.hsbarSteerAngleSensorZero.Location = new System.Drawing.Point(10, 30);
            this.hsbarSteerAngleSensorZero.Maximum = 127;
            this.hsbarSteerAngleSensorZero.Minimum = -127;
            this.hsbarSteerAngleSensorZero.Name = "hsbarSteerAngleSensorZero";
            this.hsbarSteerAngleSensorZero.Size = new System.Drawing.Size(282, 30);
            this.hsbarSteerAngleSensorZero.TabIndex = 294;
            this.hsbarSteerAngleSensorZero.ValueChanged += new System.EventHandler(this.hsbarSteerAngleSensorZero_ValueChanged);
            // 
            // lblCountsPerDegree
            // 
            this.lblCountsPerDegree.AutoSize = true;
            this.lblCountsPerDegree.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountsPerDegree.Location = new System.Drawing.Point(292, 90);
            this.lblCountsPerDegree.Name = "lblCountsPerDegree";
            this.lblCountsPerDegree.Size = new System.Drawing.Size(91, 39);
            this.lblCountsPerDegree.TabIndex = 308;
            this.lblCountsPerDegree.Text = "-888";
            // 
            // lblMaxSteerAngle
            // 
            this.lblMaxSteerAngle.AutoSize = true;
            this.lblMaxSteerAngle.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxSteerAngle.Location = new System.Drawing.Point(292, 157);
            this.lblMaxSteerAngle.Name = "lblMaxSteerAngle";
            this.lblMaxSteerAngle.Size = new System.Drawing.Size(91, 39);
            this.lblMaxSteerAngle.TabIndex = 303;
            this.lblMaxSteerAngle.Text = "-888";
            // 
            // lblSidehillDraftGain
            // 
            this.lblSidehillDraftGain.AutoSize = true;
            this.lblSidehillDraftGain.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidehillDraftGain.Location = new System.Drawing.Point(294, 224);
            this.lblSidehillDraftGain.Name = "lblSidehillDraftGain";
            this.lblSidehillDraftGain.Size = new System.Drawing.Size(91, 39);
            this.lblSidehillDraftGain.TabIndex = 268;
            this.lblSidehillDraftGain.Text = "-888";
            // 
            // lblSteerAngleSensorZero
            // 
            this.lblSteerAngleSensorZero.AutoSize = true;
            this.lblSteerAngleSensorZero.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteerAngleSensorZero.Location = new System.Drawing.Point(292, 23);
            this.lblSteerAngleSensorZero.Name = "lblSteerAngleSensorZero";
            this.lblSteerAngleSensorZero.Size = new System.Drawing.Size(91, 39);
            this.lblSteerAngleSensorZero.TabIndex = 298;
            this.lblSteerAngleSensorZero.Text = "-888";
            // 
            // tabStan
            // 
            this.tabStan.BackColor = System.Drawing.Color.PowderBlue;
            this.tabStan.Controls.Add(this.label27);
            this.tabStan.Controls.Add(this.label6);
            this.tabStan.Controls.Add(this.label16);
            this.tabStan.Controls.Add(this.label15);
            this.tabStan.Controls.Add(this.hsbarHeadingErrorGain);
            this.tabStan.Controls.Add(this.lblStanleyGain);
            this.tabStan.Controls.Add(this.hsbarStanleyGain);
            this.tabStan.Controls.Add(this.label3);
            this.tabStan.Controls.Add(this.btnPlusTenth);
            this.tabStan.Controls.Add(this.label5);
            this.tabStan.Controls.Add(this.lblHeadingErrorGain);
            this.tabStan.Controls.Add(this.btnMinusTenth);
            this.tabStan.Controls.Add(this.btnChart);
            this.tabStan.Location = new System.Drawing.Point(4, 52);
            this.tabStan.Name = "tabStan";
            this.tabStan.Size = new System.Drawing.Size(387, 295);
            this.tabStan.TabIndex = 15;
            this.tabStan.Text = "Stanley";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(312, 234);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 16);
            this.label27.TabIndex = 327;
            this.label27.Text = "Right";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(201, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 326;
            this.label6.Text = "Left";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(299, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 16);
            this.label16.TabIndex = 324;
            this.label16.Text = "Heading";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(299, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 16);
            this.label15.TabIndex = 323;
            this.label15.Text = "Distance";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hsbarHeadingErrorGain
            // 
            this.hsbarHeadingErrorGain.LargeChange = 1;
            this.hsbarHeadingErrorGain.Location = new System.Drawing.Point(7, 104);
            this.hsbarHeadingErrorGain.Maximum = 30;
            this.hsbarHeadingErrorGain.Minimum = 1;
            this.hsbarHeadingErrorGain.Name = "hsbarHeadingErrorGain";
            this.hsbarHeadingErrorGain.Size = new System.Drawing.Size(285, 30);
            this.hsbarHeadingErrorGain.TabIndex = 294;
            this.hsbarHeadingErrorGain.Value = 5;
            this.hsbarHeadingErrorGain.ValueChanged += new System.EventHandler(this.hsbarHeadingErrorGain_ValueChanged);
            // 
            // lblStanleyGain
            // 
            this.lblStanleyGain.AutoSize = true;
            this.lblStanleyGain.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStanleyGain.Location = new System.Drawing.Point(293, 23);
            this.lblStanleyGain.Name = "lblStanleyGain";
            this.lblStanleyGain.Size = new System.Drawing.Size(91, 39);
            this.lblStanleyGain.TabIndex = 299;
            this.lblStanleyGain.Text = "-888";
            // 
            // hsbarStanleyGain
            // 
            this.hsbarStanleyGain.LargeChange = 1;
            this.hsbarStanleyGain.Location = new System.Drawing.Point(7, 30);
            this.hsbarStanleyGain.Maximum = 30;
            this.hsbarStanleyGain.Minimum = 1;
            this.hsbarStanleyGain.Name = "hsbarStanleyGain";
            this.hsbarStanleyGain.Size = new System.Drawing.Size(285, 30);
            this.hsbarStanleyGain.TabIndex = 297;
            this.hsbarStanleyGain.Value = 10;
            this.hsbarStanleyGain.ValueChanged += new System.EventHandler(this.hsbarStanleyGain_ValueChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 23);
            this.label3.TabIndex = 298;
            this.label3.Text = "Agressiveness";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlusTenth
            // 
            this.btnPlusTenth.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusTenth.Location = new System.Drawing.Point(280, 253);
            this.btnPlusTenth.Name = "btnPlusTenth";
            this.btnPlusTenth.Size = new System.Drawing.Size(102, 29);
            this.btnPlusTenth.TabIndex = 325;
            this.btnPlusTenth.Text = "+0.1";
            this.btnPlusTenth.UseVisualStyleBackColor = true;
            this.btnPlusTenth.Click += new System.EventHandler(this.btnPlusTenth_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 23);
            this.label5.TabIndex = 296;
            this.label5.Text = "Overshoot Reduction";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeadingErrorGain
            // 
            this.lblHeadingErrorGain.AutoSize = true;
            this.lblHeadingErrorGain.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingErrorGain.Location = new System.Drawing.Point(293, 97);
            this.lblHeadingErrorGain.Name = "lblHeadingErrorGain";
            this.lblHeadingErrorGain.Size = new System.Drawing.Size(91, 39);
            this.lblHeadingErrorGain.TabIndex = 295;
            this.lblHeadingErrorGain.Text = "-888";
            // 
            // btnMinusTenth
            // 
            this.btnMinusTenth.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusTenth.Location = new System.Drawing.Point(168, 253);
            this.btnMinusTenth.Name = "btnMinusTenth";
            this.btnMinusTenth.Size = new System.Drawing.Size(102, 29);
            this.btnMinusTenth.TabIndex = 324;
            this.btnMinusTenth.Text = "- 0.1";
            this.btnMinusTenth.UseVisualStyleBackColor = true;
            this.btnMinusTenth.Click += new System.EventHandler(this.btnMinusTenth_Click);
            // 
            // btnChart
            // 
            this.btnChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChart.BackColor = System.Drawing.Color.Transparent;
            this.btnChart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnChart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChart.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.ForeColor = System.Drawing.Color.Black;
            this.btnChart.Location = new System.Drawing.Point(6, 253);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(130, 29);
            this.btnChart.TabIndex = 234;
            this.btnChart.Text = "Steer Chart";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // tabInt
            // 
            this.tabInt.BackColor = System.Drawing.Color.PowderBlue;
            this.tabInt.Controls.Add(this.label24);
            this.tabInt.Controls.Add(this.nudIntDistance);
            this.tabInt.Controls.Add(this.nudIntHeading);
            this.tabInt.Controls.Add(this.lblDistanceAway);
            this.tabInt.Controls.Add(this.label14);
            this.tabInt.Controls.Add(this.label20);
            this.tabInt.Controls.Add(this.label26);
            this.tabInt.Controls.Add(this.lblAvgXTE);
            this.tabInt.Controls.Add(this.label22);
            this.tabInt.Controls.Add(this.hsbarAvgXTE);
            this.tabInt.Controls.Add(this.label17);
            this.tabInt.Controls.Add(this.lblStanleyIntegralGain);
            this.tabInt.Controls.Add(this.label18);
            this.tabInt.Controls.Add(this.hsbarIntegralGain);
            this.tabInt.Controls.Add(this.label21);
            this.tabInt.Controls.Add(this.label23);
            this.tabInt.Location = new System.Drawing.Point(4, 52);
            this.tabInt.Name = "tabInt";
            this.tabInt.Size = new System.Drawing.Size(387, 295);
            this.tabInt.TabIndex = 16;
            this.tabInt.Text = "Integral";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(5, 108);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 23);
            this.label24.TabIndex = 336;
            this.label24.Text = "Less";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudIntDistance
            // 
            this.nudIntDistance.BackColor = System.Drawing.Color.AliceBlue;
            this.nudIntDistance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIntDistance.InterceptArrowKeys = false;
            this.nudIntDistance.Location = new System.Drawing.Point(176, 42);
            this.nudIntDistance.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudIntDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIntDistance.Name = "nudIntDistance";
            this.nudIntDistance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudIntDistance.Size = new System.Drawing.Size(85, 46);
            this.nudIntDistance.TabIndex = 335;
            this.nudIntDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudIntDistance.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudIntDistance.ValueChanged += new System.EventHandler(this.nudIntDistance_ValueChanged);
            this.nudIntDistance.Enter += new System.EventHandler(this.nudIntDistance_Enter);
            // 
            // nudIntHeading
            // 
            this.nudIntHeading.BackColor = System.Drawing.Color.AliceBlue;
            this.nudIntHeading.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIntHeading.InterceptArrowKeys = false;
            this.nudIntHeading.Location = new System.Drawing.Point(24, 42);
            this.nudIntHeading.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudIntHeading.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIntHeading.Name = "nudIntHeading";
            this.nudIntHeading.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudIntHeading.Size = new System.Drawing.Size(85, 46);
            this.nudIntHeading.TabIndex = 334;
            this.nudIntHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudIntHeading.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudIntHeading.ValueChanged += new System.EventHandler(this.nudIntHeading_ValueChanged);
            this.nudIntHeading.Enter += new System.EventHandler(this.nudIntHeading_Enter);
            // 
            // lblDistanceAway
            // 
            this.lblDistanceAway.BackColor = System.Drawing.Color.Transparent;
            this.lblDistanceAway.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanceAway.Location = new System.Drawing.Point(153, 16);
            this.lblDistanceAway.Name = "lblDistanceAway";
            this.lblDistanceAway.Size = new System.Drawing.Size(134, 23);
            this.lblDistanceAway.TabIndex = 331;
            this.lblDistanceAway.Text = "Distance (cm)";
            this.lblDistanceAway.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 23);
            this.label14.TabIndex = 327;
            this.label14.Text = "Heading (Deg)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label20.Location = new System.Drawing.Point(297, 202);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 16);
            this.label20.TabIndex = 332;
            this.label20.Text = "%";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(237, 108);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 23);
            this.label26.TabIndex = 335;
            this.label26.Text = "More";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvgXTE
            // 
            this.lblAvgXTE.AutoSize = true;
            this.lblAvgXTE.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgXTE.Location = new System.Drawing.Point(293, 216);
            this.lblAvgXTE.Name = "lblAvgXTE";
            this.lblAvgXTE.Size = new System.Drawing.Size(91, 39);
            this.lblAvgXTE.TabIndex = 330;
            this.lblAvgXTE.Text = "-888";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(72, 176);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(129, 46);
            this.label22.TabIndex = 331;
            this.label22.Text = "Cross Track Smoothing";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarAvgXTE
            // 
            this.hsbarAvgXTE.LargeChange = 1;
            this.hsbarAvgXTE.Location = new System.Drawing.Point(5, 224);
            this.hsbarAvgXTE.Maximum = 99;
            this.hsbarAvgXTE.Minimum = 1;
            this.hsbarAvgXTE.Name = "hsbarAvgXTE";
            this.hsbarAvgXTE.Size = new System.Drawing.Size(285, 30);
            this.hsbarAvgXTE.TabIndex = 329;
            this.hsbarAvgXTE.Value = 5;
            this.hsbarAvgXTE.ValueChanged += new System.EventHandler(this.hsbarSteerStep_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(296, 111);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 16);
            this.label17.TabIndex = 328;
            this.label17.Text = "Gain";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStanleyIntegralGain
            // 
            this.lblStanleyIntegralGain.AutoSize = true;
            this.lblStanleyIntegralGain.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStanleyIntegralGain.Location = new System.Drawing.Point(292, 126);
            this.lblStanleyIntegralGain.Name = "lblStanleyIntegralGain";
            this.lblStanleyIntegralGain.Size = new System.Drawing.Size(91, 39);
            this.lblStanleyIntegralGain.TabIndex = 326;
            this.lblStanleyIntegralGain.Text = "-888";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(70, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(161, 23);
            this.label18.TabIndex = 327;
            this.label18.Text = "Integral";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarIntegralGain
            // 
            this.hsbarIntegralGain.LargeChange = 1;
            this.hsbarIntegralGain.Location = new System.Drawing.Point(4, 134);
            this.hsbarIntegralGain.Name = "hsbarIntegralGain";
            this.hsbarIntegralGain.Size = new System.Drawing.Size(285, 30);
            this.hsbarIntegralGain.TabIndex = 325;
            this.hsbarIntegralGain.Value = 5;
            this.hsbarIntegralGain.ValueChanged += new System.EventHandler(this.hsbarIntegralGain_ValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(238, 196);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 23);
            this.label21.TabIndex = 333;
            this.label21.Text = "More";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 196);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 23);
            this.label23.TabIndex = 334;
            this.label23.Text = "Less";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblSteerAngle
            // 
            this.lblSteerAngle.BackColor = System.Drawing.Color.Transparent;
            this.lblSteerAngle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteerAngle.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblSteerAngle.Location = new System.Drawing.Point(45, 356);
            this.lblSteerAngle.Name = "lblSteerAngle";
            this.lblSteerAngle.Size = new System.Drawing.Size(79, 23);
            this.lblSteerAngle.TabIndex = 306;
            this.lblSteerAngle.Text = "-55.5";
            this.lblSteerAngle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRecd
            // 
            this.lblRecd.AutoSize = true;
            this.lblRecd.BackColor = System.Drawing.Color.Transparent;
            this.lblRecd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecd.Location = new System.Drawing.Point(73, 451);
            this.lblRecd.Name = "lblRecd";
            this.lblRecd.Size = new System.Drawing.Size(32, 16);
            this.lblRecd.TabIndex = 309;
            this.lblRecd.Text = "255";
            this.lblRecd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSent
            // 
            this.lblSent.AutoSize = true;
            this.lblSent.BackColor = System.Drawing.Color.Transparent;
            this.lblSent.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSent.Location = new System.Drawing.Point(41, 451);
            this.lblSent.Name = "lblSent";
            this.lblSent.Size = new System.Drawing.Size(32, 16);
            this.lblSent.TabIndex = 310;
            this.lblSent.Text = "255";
            this.lblSent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSteerAngleActual
            // 
            this.lblSteerAngleActual.BackColor = System.Drawing.Color.Transparent;
            this.lblSteerAngleActual.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteerAngleActual.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblSteerAngleActual.Location = new System.Drawing.Point(45, 382);
            this.lblSteerAngleActual.Name = "lblSteerAngleActual";
            this.lblSteerAngleActual.Size = new System.Drawing.Size(70, 23);
            this.lblSteerAngleActual.TabIndex = 311;
            this.lblSteerAngleActual.Text = "-55.5";
            this.lblSteerAngleActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(45, 413);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(70, 23);
            this.lblError.TabIndex = 312;
            this.lblError.Text = "-30.0";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFreeDriveZero
            // 
            this.btnFreeDriveZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFreeDriveZero.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreeDriveZero.Location = new System.Drawing.Point(134, 444);
            this.btnFreeDriveZero.Name = "btnFreeDriveZero";
            this.btnFreeDriveZero.Size = new System.Drawing.Size(118, 28);
            this.btnFreeDriveZero.TabIndex = 313;
            this.btnFreeDriveZero.Text = ">0<   or   +5";
            this.btnFreeDriveZero.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFreeDriveZero.UseVisualStyleBackColor = true;
            this.btnFreeDriveZero.Click += new System.EventHandler(this.btnFreeDriveZero_Click);
            // 
            // btnSteerAngleDown
            // 
            this.btnSteerAngleDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSteerAngleDown.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSteerAngleDown.Image = global::Drive.Properties.Resources.ArrowLeft;
            this.btnSteerAngleDown.Location = new System.Drawing.Point(107, 484);
            this.btnSteerAngleDown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSteerAngleDown.Name = "btnSteerAngleDown";
            this.btnSteerAngleDown.Size = new System.Drawing.Size(83, 45);
            this.btnSteerAngleDown.TabIndex = 314;
            this.btnSteerAngleDown.UseVisualStyleBackColor = true;
            this.btnSteerAngleDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSteerAngleDown_MouseDown);
            // 
            // btnSteerAngleUp
            // 
            this.btnSteerAngleUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSteerAngleUp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSteerAngleUp.Image = global::Drive.Properties.Resources.ArrowRight;
            this.btnSteerAngleUp.Location = new System.Drawing.Point(210, 484);
            this.btnSteerAngleUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSteerAngleUp.Name = "btnSteerAngleUp";
            this.btnSteerAngleUp.Size = new System.Drawing.Size(83, 45);
            this.btnSteerAngleUp.TabIndex = 315;
            this.btnSteerAngleUp.UseVisualStyleBackColor = true;
            this.btnSteerAngleUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSteerAngleUp_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 317;
            this.label8.Text = "Chk:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 23);
            this.label11.TabIndex = 319;
            this.label11.Text = "Act:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 358);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 23);
            this.label12.TabIndex = 320;
            this.label12.Text = "Set:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 414);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 23);
            this.label13.TabIndex = 321;
            this.label13.Text = "Err:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMinus20
            // 
            this.btnMinus20.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus20.Location = new System.Drawing.Point(6, 484);
            this.btnMinus20.Name = "btnMinus20";
            this.btnMinus20.Size = new System.Drawing.Size(83, 45);
            this.btnMinus20.TabIndex = 323;
            this.btnMinus20.Text = "-20";
            this.btnMinus20.UseVisualStyleBackColor = true;
            this.btnMinus20.Click += new System.EventHandler(this.btnMinus20_Click);
            // 
            // btnPlus20
            // 
            this.btnPlus20.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus20.Location = new System.Drawing.Point(310, 484);
            this.btnPlus20.Name = "btnPlus20";
            this.btnPlus20.Size = new System.Drawing.Size(83, 45);
            this.btnPlus20.TabIndex = 324;
            this.btnPlus20.Text = "+20";
            this.btnPlus20.UseVisualStyleBackColor = true;
            this.btnPlus20.Click += new System.EventHandler(this.btnPlus20_Click);
            // 
            // pbActPos
            // 
            this.pbActPos.Location = new System.Drawing.Point(245, 385);
            this.pbActPos.Name = "pbActPos";
            this.pbActPos.Size = new System.Drawing.Size(126, 18);
            this.pbActPos.Step = 1;
            this.pbActPos.TabIndex = 325;
            // 
            // pbActNeg
            // 
            this.pbActNeg.Location = new System.Drawing.Point(117, 385);
            this.pbActNeg.Name = "pbActNeg";
            this.pbActNeg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pbActNeg.RightToLeftLayout = true;
            this.pbActNeg.Size = new System.Drawing.Size(126, 18);
            this.pbActNeg.Step = 1;
            this.pbActNeg.TabIndex = 326;
            // 
            // pbSetNeg
            // 
            this.pbSetNeg.Location = new System.Drawing.Point(117, 358);
            this.pbSetNeg.Name = "pbSetNeg";
            this.pbSetNeg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pbSetNeg.RightToLeftLayout = true;
            this.pbSetNeg.Size = new System.Drawing.Size(126, 18);
            this.pbSetNeg.Step = 1;
            this.pbSetNeg.TabIndex = 328;
            // 
            // pbSetPos
            // 
            this.pbSetPos.Location = new System.Drawing.Point(245, 358);
            this.pbSetPos.Name = "pbSetPos";
            this.pbSetPos.Size = new System.Drawing.Size(126, 18);
            this.pbSetPos.Step = 1;
            this.pbSetPos.TabIndex = 327;
            // 
            // pbErrNeg
            // 
            this.pbErrNeg.Location = new System.Drawing.Point(117, 415);
            this.pbErrNeg.Maximum = 50;
            this.pbErrNeg.Name = "pbErrNeg";
            this.pbErrNeg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pbErrNeg.RightToLeftLayout = true;
            this.pbErrNeg.Size = new System.Drawing.Size(126, 18);
            this.pbErrNeg.Step = 1;
            this.pbErrNeg.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbErrNeg.TabIndex = 330;
            // 
            // pbErrPos
            // 
            this.pbErrPos.Location = new System.Drawing.Point(245, 415);
            this.pbErrPos.Maximum = 50;
            this.pbErrPos.Name = "pbErrPos";
            this.pbErrPos.Size = new System.Drawing.Size(126, 18);
            this.pbErrPos.Step = 1;
            this.pbErrPos.TabIndex = 329;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 333;
            this.label1.Text = "5";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 334;
            this.label2.Text = "10";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 335;
            this.label4.Text = "10";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormSteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(400, 535);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbErrNeg);
            this.Controls.Add(this.btnFreeDrive);
            this.Controls.Add(this.btnPlus20);
            this.Controls.Add(this.pbErrPos);
            this.Controls.Add(this.pbSetNeg);
            this.Controls.Add(this.pbActNeg);
            this.Controls.Add(this.pbActPos);
            this.Controls.Add(this.pbSetPos);
            this.Controls.Add(this.btnMinus20);
            this.Controls.Add(this.btnSteerAngleDown);
            this.Controls.Add(this.btnSteerAngleUp);
            this.Controls.Add(this.btnFreeDriveZero);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblSteerAngle);
            this.Controls.Add(this.lblSteerAngleActual);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblSent);
            this.Controls.Add(this.lblRecd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSteer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Auto Steer Configuration";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSteer_FormClosing);
            this.Load += new System.EventHandler(this.FormSteer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabGain.ResumeLayout(false);
            this.tabGain.PerformLayout();
            this.tabSteer.ResumeLayout(false);
            this.tabSteer.PerformLayout();
            this.tabStan.ResumeLayout(false);
            this.tabStan.PerformLayout();
            this.tabInt.ResumeLayout(false);
            this.tabInt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntHeading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFreeDrive;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSteer;
        private System.Windows.Forms.TabPage tabGain;
        private System.Windows.Forms.Label lblHighSteerPWM;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.HScrollBar hsbarHighSteerPWM;
        private System.Windows.Forms.Label lblLowSteerPWM;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.HScrollBar hsbarLowSteerPWM;
        private System.Windows.Forms.Label lblSidehillDraftGain;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.HScrollBar hsbarSidehillDraftGain;
        private System.Windows.Forms.Label lblProportionalGain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.HScrollBar hsbarProportionalGain;
        private System.Windows.Forms.Label lblMinPWM;
        private System.Windows.Forms.HScrollBar hsbarMinPWM;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label lblCountsPerDegree;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.HScrollBar hsbarCountsPerDegree;
        private System.Windows.Forms.Label lblMaxSteerAngle;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.HScrollBar hsbarMaxSteerAngle;
        private System.Windows.Forms.Label lblSteerAngleSensorZero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.HScrollBar hsbarSteerAngleSensorZero;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.TabPage tabStan;
        private System.Windows.Forms.HScrollBar hsbarHeadingErrorGain;
        private System.Windows.Forms.Label lblStanleyGain;
        private System.Windows.Forms.HScrollBar hsbarStanleyGain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHeadingErrorGain;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSteerAngle;
        private System.Windows.Forms.Label lblRecd;
        private System.Windows.Forms.Label lblSent;
        private System.Windows.Forms.Label lblSteerAngleActual;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnFreeDriveZero;
        private ProXoft.WinForms.RepeatButton btnSteerAngleDown;
        private ProXoft.WinForms.RepeatButton btnSteerAngleUp;
        private System.Windows.Forms.Label lblPWMDisplay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.HScrollBar hsbarIntegralGain;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblStanleyIntegralGain;
        private System.Windows.Forms.TabPage tabInt;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblAvgXTE;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.HScrollBar hsbarAvgXTE;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnMinus20;
        private System.Windows.Forms.Button btnPlus20;
        private System.Windows.Forms.ProgressBar pbActPos;
        private System.Windows.Forms.ProgressBar pbActNeg;
        private System.Windows.Forms.ProgressBar pbSetNeg;
        private System.Windows.Forms.ProgressBar pbSetPos;
        private System.Windows.Forms.ProgressBar pbErrNeg;
        private System.Windows.Forms.ProgressBar pbErrPos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPlusTenth;
        private System.Windows.Forms.Button btnMinusTenth;
        private System.Windows.Forms.Label lblDistanceAway;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudIntDistance;
        private System.Windows.Forms.NumericUpDown nudIntHeading;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label6;
    }
}