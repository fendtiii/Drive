namespace Drive
{
    public class CAutoSteer
    {
        private readonly FormGPS mf;

        //flag for free drive window to control autosteer
        public bool isInFreeDriveMode;

        //the trackbar angle for free drive
        public double driveFreeSteerAngle = 0;

        //close to guidance line criteria
        public double integralDistanceAway, integralHeadingLimit;

        public double stanleyGain, stanleyHeadingErrorGain, stanleyIntegralGain, avgXTE;

        //constructor
        public CAutoSteer(FormGPS _f)
        {
            mf = _f;
            isInFreeDriveMode = false;

            integralDistanceAway = (double)Properties.Vehicle.Default.setSteer_integralDistanceAway * 0.01;
            integralHeadingLimit = Properties.Vehicle.Default.setSteer_integralHeading;

            stanleyGain = Properties.Vehicle.Default.setVehicle_stanleyGain;
            stanleyHeadingErrorGain = Properties.Vehicle.Default.setVehicle_stanleyHeadingErrorGain;
            stanleyIntegralGain = Properties.Vehicle.Default.setSteer_integralGain;
            avgXTE = Properties.Vehicle.Default.setSteer_averageXTE;

        }
    }
}