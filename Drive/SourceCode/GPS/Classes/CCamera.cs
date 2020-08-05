using OpenTK.Graphics.OpenGL;
using System;

namespace Drive
{
    public class CCamera
    {
        private readonly FormGPS mf;

        private double camPosX;
        private double camPosY;
        private readonly double camPosZ;

        //private double fixHeading;
        private double camHeading;
        private double camCorrection;

        public double camFloat, camPitch;
        public double offset;
        public double camSetDistance = -75;

        public double gridZoom;

        public double zoomValue = 7;
        public double previousZoom = 25;

        public bool camFollowing;
        public int camMode = 0;

        //private double camDelta = 0;

        public CCamera(FormGPS _f)
        {
            //constructor
            mf = _f;

            //get the pitch of camera from settings
            camPitch = Properties.Settings.Default.setDisplay_camPitch;
            camPosZ = 0.0;
            camFollowing = true;
        }

        public void SetWorldCam(double _fixPosX, double _fixPosY, double _fixHeading)
        {
            camPosX = _fixPosX;
            camPosY = _fixPosY;
            camHeading = glm.toRadians(_fixHeading);

            //Difference between the cam heading and the desired heading
            double camDelta = (camFloat) - camHeading;
            if (camDelta < 0) camDelta += glm.twoPI;

            //calculate delta based on circular data problem 0 to 360 to 0, clamp to +- 2 Pi
            if (camDelta >= -glm.PIBy2 && camDelta <= glm.PIBy2) camDelta *= -1.0;
            else
            {
                if (camDelta > glm.PIBy2)
                { camDelta = glm.twoPI - camDelta; }
                else { camDelta = (glm.twoPI + camDelta) * -1.0; }
            }

            if (camDelta > glm.twoPI) camDelta -= glm.twoPI;
            else if (camDelta < -glm.twoPI) camDelta += glm.twoPI;

            //a bit of delta and add to correction to current cam
            camCorrection = (camDelta * (1.5/mf.fixUpdateHz));
            if (camCorrection > glm.twoPI) camCorrection -= glm.twoPI;
            else if (camCorrection < -glm.twoPI) camCorrection += glm.twoPI;

            //determine the Corrected heading based on cam and GPS
            camFloat = camFloat + camCorrection;
            if (camFloat > glm.twoPI) camFloat -= glm.twoPI;
            if (camFloat < 0) camFloat += glm.twoPI;

            //back the camera up
            GL.Translate(0.0, 0.0, camSetDistance * 0.5);
            //rotate the camera down to look at fix
            GL.Rotate(camPitch, 1.0, 0.0, 0.0);

            ////draw the guide
            //GL.Begin(PrimitiveType.Triangles);
            //GL.Color3(0.98f, 0.0f, 0.0f);
            //GL.Vertex3(0.0f, -2.0f, 0.0f);
            //GL.Color3(0.0f, 0.98f, 0.0f);
            //GL.Vertex3(-2.0f, -3.0f, 0.0f);
            //GL.Color3(0.98f, 0.98f, 0.0f);
            //GL.Vertex3(2.0f, -3.0f, 0.0f);
            //GL.End();						// Done Drawing Reticle

            //following game style or N floating fixed cam
            if (camFollowing)
            {
                GL.Rotate(glm.toDegrees(camFloat), 0.0, 0.0, 1.0);
                GL.Translate(-camPosX, -camPosY, -camPosZ);
            }
            else
            {
                GL.Translate(-camPosX, -camPosY, -camPosZ);
            }
        }
    }
}