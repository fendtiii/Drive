using System;
using System.Drawing;
using System.Windows.Forms;

namespace Drive
{
    public partial class FormSteer : Form
    {
        private readonly FormGPS mf = null;

        bool toSend = false;

        //Form stuff
        public FormSteer(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();

            this.btnFreeDrive.Text = gStr.gsDrive;
            this.tabGain.Text = gStr.gsGain;
            this.label29.Text = gStr.gsSidehillDraftGain;
            //this.label22.Text = gStr.gsOutputGain;
            this.label41.Text = gStr.gsMinimumPWMDrive;
            this.label7.Text = gStr.gsProportionalGain;

            this.tabSteer.Text = gStr.gsSteer;
            this.label25.Text = gStr.gsCountsPerDegree;
            //this.label45.Text = gStr.gsMaxIntegralValue;
            this.label19.Text = gStr.gsMaxSteerAngleInDegrees;
            //this.label33.Text = gStr.gsIntegralGain;
            this.label10.Text = gStr.gsWheelAngleSensorZero;


            this.tabStan.Text = "Stanley";
            this.btnChart.Text = gStr.gsSteerChart;
            this.label3.Text = gStr.gsAgressiveness;
            this.label5.Text = gStr.gsOvershootReduction;
            this.Text = gStr.gsAutoSteerConfiguration;

            nudIntDistance.Controls[0].Enabled = false;
            nudIntHeading.Controls[0].Enabled = false;

        }

        private void FormSteer_Load(object sender, EventArgs e)
        {
            hsbarSteerAngleSensorZero.Value = Properties.Settings.Default.setAS_steerAngleOffset - 127;
            lblSteerAngleSensorZero.Text = hsbarSteerAngleSensorZero.Value.ToString();

            hsbarCountsPerDegree.Value = Properties.Settings.Default.setAS_countsPerDegree;
            lblCountsPerDegree.Text = hsbarCountsPerDegree.Value.ToString();

            hsbarMinPWM.Value = Properties.Settings.Default.setAS_minSteerPWM;
            lblMinPWM.Text = hsbarMinPWM.Value.ToString();

            hsbarProportionalGain.Value = Properties.Settings.Default.setAS_Kp;
            lblProportionalGain.Text = hsbarProportionalGain.Value.ToString();

            //hsbarOutputGain.Value = Properties.Settings.Default.setAS_Ko;
            //lblOutputGain.Text = hsbarOutputGain.Value.ToString();

            hsbarSidehillDraftGain.Value = Properties.Settings.Default.setAS_Kd;
            lblSidehillDraftGain.Text = hsbarSidehillDraftGain.Value.ToString();

            hsbarLowSteerPWM.ValueChanged -= hsbarLowSteerPWM_ValueChanged;
            hsbarHighSteerPWM.ValueChanged -= hsbarMinPWM_ValueChanged;

            hsbarLowSteerPWM.Value = Properties.Settings.Default.setAS_lowSteerPWM;
            lblLowSteerPWM.Text = (mf.mc.autoSteerSettings[mf.mc.ssLowPWM]).ToString();

            hsbarHighSteerPWM.Value = Properties.Settings.Default.setAS_highSteerPWM;
            lblHighSteerPWM.Text = hsbarHighSteerPWM.Value.ToString();

            hsbarLowSteerPWM.ValueChanged += hsbarLowSteerPWM_ValueChanged;
            hsbarHighSteerPWM.ValueChanged += hsbarMinPWM_ValueChanged;

            mf.vehicle.maxSteerAngle = Properties.Vehicle.Default.setVehicle_maxSteerAngle;
            hsbarMaxSteerAngle.Value = (Int16)mf.vehicle.maxSteerAngle;
            lblMaxSteerAngle.Text = hsbarMaxSteerAngle.Value.ToString();

            mf.ast.stanleyGain = Properties.Vehicle.Default.setVehicle_stanleyGain;
            hsbarStanleyGain.Value = (Int16)(mf.ast.stanleyGain * 10);
            lblStanleyGain.Text = mf.ast.stanleyGain.ToString();

            mf.ast.stanleyHeadingErrorGain = Properties.Vehicle.Default.setVehicle_stanleyHeadingErrorGain;
            hsbarHeadingErrorGain.Value = (Int16)(mf.ast.stanleyHeadingErrorGain * 10);
            lblHeadingErrorGain.Text = mf.ast.stanleyHeadingErrorGain.ToString();

            mf.ast.stanleyIntegralGain = Properties.Vehicle.Default.setSteer_integralGain;
            hsbarIntegralGain.Value = (Int16)(mf.ast.stanleyIntegralGain * 100);
            lblStanleyIntegralGain.Text = mf.ast.stanleyIntegralGain.ToString("N2");

            mf.ast.avgXTE = Properties.Vehicle.Default.setSteer_averageXTE;
            hsbarAvgXTE.Value = (Int16)(mf.ast.avgXTE * 100);
            lblAvgXTE.Text = hsbarAvgXTE.Value.ToString();

            nudIntHeading.ValueChanged -= nudIntHeading_ValueChanged;
            nudIntHeading.Value = (decimal)mf.ast.integralHeadingLimit;
            nudIntHeading.ValueChanged += nudIntHeading_ValueChanged;

            nudIntDistance.ValueChanged -= nudIntDistance_ValueChanged;
            nudIntDistance.Value = (decimal)mf.ast.integralDistanceAway*100;
            nudIntDistance.ValueChanged += nudIntDistance_ValueChanged;

            //make sure free drive is off
            btnFreeDrive.BackColor = Color.Red;
            mf.ast.isInFreeDriveMode = false;
            btnSteerAngleDown.Enabled = false;
            btnSteerAngleUp.Enabled = false;
            //hSBarFreeDrive.Value = 0;
            mf.ast.driveFreeSteerAngle = 0;
            toSend = false;
        }

        private void FormSteer_FormClosing(object sender, FormClosingEventArgs e)
        {
            mf.ast.isInFreeDriveMode = false;
            Properties.Settings.Default.Save();
            Properties.Vehicle.Default.Save();
        }

        //Stanley Page tab
        private void hsbarStanleyGain_ValueChanged(object sender, EventArgs e)
        {
            mf.ast.stanleyGain = hsbarStanleyGain.Value * 0.1;
            lblStanleyGain.Text = mf.ast.stanleyGain.ToString();
            Properties.Vehicle.Default.setVehicle_stanleyGain = mf.ast.stanleyGain;
        }

        private void hsbarHeadingErrorGain_ValueChanged(object sender, EventArgs e)
        {
            mf.ast.stanleyHeadingErrorGain = hsbarHeadingErrorGain.Value * 0.1;
            lblHeadingErrorGain.Text = mf.ast.stanleyHeadingErrorGain.ToString();
            Properties.Vehicle.Default.setVehicle_stanleyHeadingErrorGain = mf.ast.stanleyHeadingErrorGain;
        }

        //Integral Page
        private void hsbarIntegralGain_ValueChanged(object sender, EventArgs e)
        {
            mf.ast.stanleyIntegralGain = hsbarIntegralGain.Value * 0.01;
            lblStanleyIntegralGain.Text=mf.ast.stanleyIntegralGain.ToString("N2");
            Properties.Vehicle.Default.setSteer_integralGain = mf.ast.stanleyIntegralGain;
        }

        private void hsbarSteerStep_ValueChanged(object sender, EventArgs e)
        {
            mf.ast.avgXTE = hsbarAvgXTE.Value * 0.01;
            lblAvgXTE.Text = hsbarAvgXTE.Value.ToString();
            Properties.Vehicle.Default.setSteer_averageXTE = mf.ast.avgXTE;
        }

        //Scrollbars
        private void hsbarCountsPerDegree_ValueChanged(object sender, EventArgs e)
        {
            mf.mc.autoSteerSettings[mf.mc.ssCountsPerDegree] = unchecked((byte)hsbarCountsPerDegree.Value);
            lblCountsPerDegree.Text = (mf.mc.autoSteerSettings[mf.mc.ssCountsPerDegree]).ToString();
            Properties.Settings.Default.setAS_countsPerDegree = mf.mc.autoSteerSettings[mf.mc.ssCountsPerDegree];
            toSend = true;
        }

        private void hsbarMaxSteerAngle_ValueChanged(object sender, EventArgs e)
        {
            mf.vehicle.maxSteerAngle = hsbarMaxSteerAngle.Value;
            lblMaxSteerAngle.Text = hsbarMaxSteerAngle.Value.ToString();
            Properties.Vehicle.Default.setVehicle_maxSteerAngle = mf.vehicle.maxSteerAngle;
        }

        private void hsbarSteerAngleSensorZero_ValueChanged(object sender, EventArgs e)
        {
            lblSteerAngleSensorZero.Text = hsbarSteerAngleSensorZero.Value.ToString();
            mf.mc.autoSteerSettings[mf.mc.ssSteerOffset] = unchecked((byte)(127 + hsbarSteerAngleSensorZero.Value));
            Properties.Settings.Default.setAS_steerAngleOffset = mf.mc.autoSteerSettings[mf.mc.ssSteerOffset];
            toSend = true;
        }

        //Stanley Parameters

        private void hsbarMinPWM_ValueChanged(object sender, EventArgs e)
        {
            mf.mc.autoSteerSettings[mf.mc.ssMinPWM] = unchecked((byte)hsbarMinPWM.Value);
            lblMinPWM.Text = (mf.mc.autoSteerSettings[mf.mc.ssMinPWM]).ToString();
            Properties.Settings.Default.setAS_minSteerPWM = mf.mc.autoSteerSettings[mf.mc.ssMinPWM];
            toSend = true;
        }

        private void hsbarProportionalGain_ValueChanged(object sender, EventArgs e)
        {
            mf.mc.autoSteerSettings[mf.mc.ssKp] = unchecked((byte)hsbarProportionalGain.Value);
            lblProportionalGain.Text = (mf.mc.autoSteerSettings[mf.mc.ssKp]).ToString();
            Properties.Settings.Default.setAS_Kp = mf.mc.autoSteerSettings[mf.mc.ssKp];
            toSend = true;
        }

        //private void hsbarOutputGain_ValueChanged(object sender, EventArgs e)
        //{
        //    mf.mc.autoSteerSettings[mf.mc.ssKo] = unchecked((byte)hsbarOutputGain.Value);
        //    lblOutputGain.Text = (mf.mc.autoSteerSettings[mf.mc.ssKo]).ToString();
        //    Properties.Settings.Default.setAS_Ko = mf.mc.autoSteerSettings[mf.mc.ssKo];
        //    toSend = true;
        //}

        private void hsbarSidehillDraftGain_ValueChanged(object sender, EventArgs e)
        {
            mf.mc.autoSteerSettings[mf.mc.ssKd] = unchecked((byte)hsbarSidehillDraftGain.Value);
            lblSidehillDraftGain.Text = (mf.mc.autoSteerSettings[mf.mc.ssKd]).ToString();
            Properties.Settings.Default.setAS_Kd = mf.mc.autoSteerSettings[mf.mc.ssKd];
            toSend = true;
        }

        private void hsbarLowSteerPWM_ValueChanged(object sender, EventArgs e)
        {
            if (hsbarLowSteerPWM.Value > hsbarHighSteerPWM.Value) hsbarHighSteerPWM.Value = hsbarLowSteerPWM.Value;
            mf.mc.autoSteerSettings[mf.mc.ssLowPWM] = unchecked((byte)hsbarLowSteerPWM.Value);
            lblLowSteerPWM.Text = (mf.mc.autoSteerSettings[mf.mc.ssLowPWM]).ToString();
            Properties.Settings.Default.setAS_lowSteerPWM = mf.mc.autoSteerSettings[mf.mc.ssLowPWM];
            toSend = true;
        }

        private void hsbarHighSteerPWM_ValueChanged(object sender, EventArgs e)
        {
            if (hsbarLowSteerPWM.Value > hsbarHighSteerPWM.Value) hsbarLowSteerPWM.Value = hsbarHighSteerPWM.Value;
            mf.mc.autoSteerSettings[mf.mc.ssHighPWM] = unchecked((byte)hsbarHighSteerPWM.Value);
            lblHighSteerPWM.Text = (mf.mc.autoSteerSettings[mf.mc.ssHighPWM]).ToString();
            Properties.Settings.Default.setAS_highSteerPWM = mf.mc.autoSteerSettings[mf.mc.ssHighPWM];
            toSend = true;
        }

        //FREE DRIVE SECTION

        //private void hSBarFreeDrive_ValueChanged(object sender, EventArgs e)
        //{
        //    mf.ast.driveFreeSteerAngle = (Int16)hSBarFreeDrive.Value;
        //}

        private void btnFreeDrive_Click(object sender, EventArgs e)
        {
            if (mf.ast.isInFreeDriveMode)
            {
                //turn OFF free drive mode
                btnFreeDrive.BackColor = Color.Red;
                mf.ast.isInFreeDriveMode = false;
                btnSteerAngleDown.Enabled = false;
                btnSteerAngleUp.Enabled = false;
                //hSBarFreeDrive.Value = 0;
                mf.ast.driveFreeSteerAngle = 0;
            }
            else
            {
                //turn ON free drive mode
                btnFreeDrive.BackColor = Color.LimeGreen;
                mf.ast.isInFreeDriveMode = true;
                btnSteerAngleDown.Enabled = true;
                btnSteerAngleUp.Enabled = true;
                //hSBarFreeDrive.Value = 0;
                mf.ast.driveFreeSteerAngle = 0;
                lblSteerAngle.Text = "0";
            }
        }

        private void btnFreeDriveZero_Click(object sender, EventArgs e)
        {
            if (mf.ast.driveFreeSteerAngle == 0)
                mf.ast.driveFreeSteerAngle = 5;
            else mf.ast.driveFreeSteerAngle = 0;
            //hSBarFreeDrive.Value = mf.ast.driveFreeSteerAngle;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (Height < 600) Height = 650;
            else Height = 400;
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            mf.steerChartStripMenu.PerformClick();
        }

        int counter = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            double angleSteer = mf.actualSteerAngleDisp * 0.01;
            lblSteerAngle.Text = mf.SetSteerAngle;
            lblSteerAngleActual.Text = (mf.actualSteerAngleDisp*0.01).ToString("N1") + "\u00B0";

            double err = (mf.actualSteerAngleDisp * 0.01 - mf.guidanceLineSteerAngle * 0.01);
            lblError.Text = Math.Abs(err).ToString("N1") + "\u00B0";
            if (err > 0) lblError.ForeColor = Color.DarkRed;
            else lblError.ForeColor = Color.DarkGreen;
            
            lblPWMDisplay.Text = mf.mc.pwmDisplay.ToString();

            int bar = (int)(10 * err);
            if (bar > 50) bar = 50;
            if (bar < -50) bar = -50;

            if (bar > 0)
            {
                pbErrPos.Value = bar;
                pbErrNeg.Value = 0;
            }
            else
            {
                pbErrPos.Value = 0;
                pbErrNeg.Value = -bar;
            }

            bar = (mf.guidanceLineSteerAngle/10);
            if (bar > 100) bar = 100;
            if (bar < -100) bar = -100;

            if (bar > 0)
            {
                pbSetPos.Value = bar;
                pbSetNeg.Value = 0;
            }
            else
            {
                pbSetPos.Value = 0;
                pbSetNeg.Value = -bar;
            }

            bar = (int)(mf.actualSteerAngleDisp*0.1);
            if (bar > 100) bar = 100;
            if (bar < -100) bar = -100;

            if (bar > 0)
            {
                pbActPos.Value = bar;
                pbActNeg.Value = 0;
            }
            else
            {
                pbActPos.Value = 0;
                pbActNeg.Value = -bar;
            }

            counter++;
            if (toSend && counter > 6)
            {
                Properties.Settings.Default.Save();
                Properties.Vehicle.Default.Save();
                mf.SendSteerSettingsOutAutoSteerPort();
                toSend = false;
                counter = 0;
            }

            if (mf.checksumSent - mf.checksumRecd == 0)
            {
                lblSent.BackColor = Color.LightGreen;
                lblRecd.BackColor = Color.LightGreen;
            }
            else
            {
                lblSent.BackColor = Color.Salmon;
                lblRecd.BackColor = Color.Salmon;
            }

            lblSent.Text = mf.checksumSent.ToString();
            lblRecd.Text = mf.checksumRecd.ToString();

            if (hsbarMinPWM.Value > hsbarLowSteerPWM.Value) lblMinPWM.ForeColor = Color.Red;
            else lblMinPWM.ForeColor = Color.Black;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Properties.Vehicle.Default.Save();
            mf.SendSteerSettingsOutAutoSteerPort();
        }

        private void btnSteerAngleUp_MouseDown(object sender, MouseEventArgs e)
        {
            mf.ast.driveFreeSteerAngle++;
            if (mf.ast.driveFreeSteerAngle > 40) mf.ast.driveFreeSteerAngle = 40;
        }

        private void btnSteerAngleDown_MouseDown(object sender, MouseEventArgs e)
        {
            mf.ast.driveFreeSteerAngle--;
            if (mf.ast.driveFreeSteerAngle < -40) mf.ast.driveFreeSteerAngle = -40;
        }

        private void btnPlus20_Click(object sender, EventArgs e)
        {
            mf.ast.driveFreeSteerAngle += 20;
        }

        private void btnMinus20_Click(object sender, EventArgs e)
        {
            mf.ast.driveFreeSteerAngle += -20;
        }

        private void btnMinusTenth_Click(object sender, EventArgs e)
        {
            mf.ast.driveFreeSteerAngle += -0.1;
        }

        private void btnPlusTenth_Click(object sender, EventArgs e)
        {
            mf.ast.driveFreeSteerAngle += 0.1;
        }

        private void nudIntDistance_Enter(object sender, EventArgs e)
        {
            mf.KeypadToNUD((NumericUpDown)sender);
            btnFreeDriveZero.Focus();
        }

        private void nudIntHeading_Enter(object sender, EventArgs e)
        {
            mf.KeypadToNUD((NumericUpDown)sender);
            btnFreeDriveZero.Focus();
        }

        private void nudIntHeading_ValueChanged(object sender, EventArgs e)
        {
            mf.ast.integralHeadingLimit = (double)nudIntHeading.Value;
            Properties.Vehicle.Default.setSteer_integralHeading = (int)mf.ast.integralHeadingLimit;
            Properties.Vehicle.Default.Save();
        }

        private void nudIntDistance_ValueChanged(object sender, EventArgs e)
        {
            mf.ast.integralDistanceAway = (double)nudIntDistance.Value*0.01;
            Properties.Vehicle.Default.setSteer_integralDistanceAway = (int)nudIntDistance.Value;
            Properties.Vehicle.Default.Save();
        }
    }
}
