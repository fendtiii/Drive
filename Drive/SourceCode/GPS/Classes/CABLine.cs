using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;

namespace Drive
{
    public class CABLine
    {
        public double abFixHeadingDelta;
        public double abHeading;
        public double angVel;
        //the current AB guidance line
        public vec2 currentABLineP1 = new vec2(0.0, 0.0);

        public vec2 currentABLineP2 = new vec2(0.0, 1.0);
        public double distanceFromCurrentLine;
        public double distanceFromRefLine;
        //pure pursuit values
        public vec2 goalPointAB = new vec2(0, 0);

        //List of all available ABLines
        public List<CABLines> lineArr = new List<CABLines>();

        public int numABLines, numABLineSelected;

        public double howManyPathsAway, moveDistance;
        public bool isABLineBeingSet, isEditing;
        public bool isABLineSet, isABLineLoaded;
        public bool isABSameAsVehicleHeading = true;
        public bool isBtnABLineOn;
        public bool isOnRightSideCurrentLine = true;

        public double passNumber;
        public double ppRadiusAB;
        public vec2 radiusPointAB = new vec2(0, 0);
        public double rEastAB, rNorthAB;
        //the reference line endpoints
        public vec2 refABLineP1 = new vec2(0.0, 0.0);
        public vec2 refABLineP2 = new vec2(0.0, 1.0);
        
        //the two inital A and B points
        public vec2 refPoint1 = new vec2(0.2, 0.15);
        public vec2 refPoint2 = new vec2(0.3, 0.3);

        public double snapDistance;
        public double steerAngleAB;
        public int lineWidth;

        //tramlines
        public List<vec2> tramArr = new List<vec2>();
        public List<List<vec2>> tramList = new List<List<vec2>>();

        //Color tramColor = Color.YellowGreen;
        public int tramPassEvery;
        //pointers to mainform controls
        private readonly FormGPS mf;

        public CABLine(FormGPS _f)
        {
            //constructor
            mf = _f;
            //isOnTramLine = true;
            lineWidth = Properties.Settings.Default.setDisplay_lineWidth;
        }

        public void DrawABLines()
        {
            //Draw AB Points
            GL.PointSize(8.0f);
            GL.Begin(PrimitiveType.Points);

            GL.Color3(0.95f, 0.0f, 0.0f);
            GL.Vertex3(refPoint1.easting, refPoint1.northing, 0.0);
            GL.Color3(0.0f, 0.90f, 0.95f);
            GL.Vertex3(refPoint2.easting, refPoint2.northing, 0.0);
            GL.End();
            
            if (mf.font.isFontOn)
            {
                mf.font.DrawText3D(refPoint1.easting, refPoint1.northing, "&A");
                mf.font.DrawText3D(refPoint2.easting, refPoint2.northing, "&B");
            }

            GL.PointSize(1.0f);

            //Draw reference AB line
            GL.LineWidth(lineWidth);
            GL.Enable(EnableCap.LineStipple);
            GL.LineStipple(1, 0x0F00);
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(0.930f, 0.2f, 0.2f);
            GL.Vertex3(refABLineP1.easting, refABLineP1.northing, 0);
            GL.Vertex3(refABLineP2.easting, refABLineP2.northing, 0);
            GL.End();
            GL.Disable(EnableCap.LineStipple);

            //draw current AB Line
            GL.LineWidth(lineWidth);
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(0.95f, 0.0f, 0.950f);
            GL.Vertex3(currentABLineP1.easting, currentABLineP1.northing, 0.0);
            GL.Vertex3(currentABLineP2.easting, currentABLineP2.northing, 0.0);
            GL.End();


            if (!isEditing)
            {
                if (mf.isSideGuideLines && mf.camera.camSetDistance > mf.tool.toolWidth * -120)
                {
                    //get the tool offset and width
                    double toolOffset = mf.tool.toolOffset * 2;
                    double toolWidth = mf.tool.toolWidth - mf.tool.toolOverlap;
                    double cosHeading = Math.Cos(-abHeading);
                    double sinHeading = Math.Sin(-abHeading);

                    GL.Color3(0.56f, 0.650f, 0.650f);
                    GL.Enable(EnableCap.LineStipple);
                    GL.LineStipple(1, 0x0101);

                    GL.LineWidth(lineWidth);
                    GL.Begin(PrimitiveType.Lines);

                    if (isABSameAsVehicleHeading)
                    {
                        GL.Vertex3((cosHeading * (toolWidth + toolOffset)) + currentABLineP1.easting, (sinHeading * (toolWidth + toolOffset)) + currentABLineP1.northing, 0);
                        GL.Vertex3((cosHeading * (toolWidth + toolOffset)) + currentABLineP2.easting, (sinHeading * (toolWidth + toolOffset)) + currentABLineP2.northing, 0);
                        GL.Vertex3((cosHeading * (-toolWidth + toolOffset)) + currentABLineP1.easting, (sinHeading * (-toolWidth + toolOffset)) + currentABLineP1.northing, 0);
                        GL.Vertex3((cosHeading * (-toolWidth + toolOffset)) + currentABLineP2.easting, (sinHeading * (-toolWidth + toolOffset)) + currentABLineP2.northing, 0);

                        toolWidth *= 2;
                        GL.Vertex3((cosHeading * toolWidth) + currentABLineP1.easting, (sinHeading * toolWidth) + currentABLineP1.northing, 0);
                        GL.Vertex3((cosHeading * toolWidth) + currentABLineP2.easting, (sinHeading * toolWidth) + currentABLineP2.northing, 0);
                        GL.Vertex3((cosHeading * (-toolWidth)) + currentABLineP1.easting, (sinHeading * (-toolWidth)) + currentABLineP1.northing, 0);
                        GL.Vertex3((cosHeading * (-toolWidth)) + currentABLineP2.easting, (sinHeading * (-toolWidth)) + currentABLineP2.northing, 0);
                    }
                    else
                    {
                        GL.Vertex3((cosHeading * (toolWidth - toolOffset)) + currentABLineP1.easting, (sinHeading * (toolWidth - toolOffset)) + currentABLineP1.northing, 0);
                        GL.Vertex3((cosHeading * (toolWidth - toolOffset)) + currentABLineP2.easting, (sinHeading * (toolWidth - toolOffset)) + currentABLineP2.northing, 0);
                        GL.Vertex3((cosHeading * (-toolWidth - toolOffset)) + currentABLineP1.easting, (sinHeading * (-toolWidth - toolOffset)) + currentABLineP1.northing, 0);
                        GL.Vertex3((cosHeading * (-toolWidth - toolOffset)) + currentABLineP2.easting, (sinHeading * (-toolWidth - toolOffset)) + currentABLineP2.northing, 0);

                        toolWidth *= 2;
                        GL.Vertex3((cosHeading * toolWidth) + currentABLineP1.easting, (sinHeading * toolWidth) + currentABLineP1.northing, 0);
                        GL.Vertex3((cosHeading * toolWidth) + currentABLineP2.easting, (sinHeading * toolWidth) + currentABLineP2.northing, 0);
                        GL.Vertex3((cosHeading * (-toolWidth)) + currentABLineP1.easting, (sinHeading * (-toolWidth)) + currentABLineP1.northing, 0);
                        GL.Vertex3((cosHeading * (-toolWidth)) + currentABLineP2.easting, (sinHeading * (-toolWidth)) + currentABLineP2.northing, 0);
                    }

                    GL.End();
                    GL.Disable(EnableCap.LineStipple);
                }
            }

            if (isEditing)
            {
                double toolWidth2 = mf.tool.toolWidth - mf.tool.toolOverlap;
                double cosHeading2 = Math.Cos(-mf.ABLine.abHeading);
                double sinHeading2 = Math.Sin(-mf.ABLine.abHeading);

                if (mf.camera.camSetDistance > -200)
                {
                    GL.Color3(0.9630f, 0.2f, 0.2f);
                    GL.LineWidth(mf.ABLine.lineWidth);
                    GL.Enable(EnableCap.LineStipple);
                    GL.LineStipple(1, 0x0707);

                    GL.Begin(PrimitiveType.Lines);

                    for (int i = 1; i <= 6; i++)
                    {
                        GL.Vertex3((cosHeading2 * toolWidth2) + mf.ABLine.refABLineP1.easting, (sinHeading2 * toolWidth2) + mf.ABLine.refABLineP1.northing, 0);
                        GL.Vertex3((cosHeading2 * toolWidth2) + mf.ABLine.refABLineP2.easting, (sinHeading2 * toolWidth2) + mf.ABLine.refABLineP2.northing, 0);
                        toolWidth2 = toolWidth2 + mf.tool.toolWidth - mf.tool.toolOverlap;
                    }

                    GL.End();
                    GL.Disable(EnableCap.LineStipple);
                }
            }

            if (mf.isPureDisplayOn && !mf.isStanleyUsed)
            {
                //Draw lookahead Point
                GL.PointSize(8.0f);
                GL.Begin(PrimitiveType.Points);
                GL.Color3(1.0f, 1.0f, 0.0f);
                GL.Vertex3(goalPointAB.easting, goalPointAB.northing, 0.0);
                //GL.Vertex3(rEastAB, rNorthAB, 0.0);
                GL.End();
                GL.PointSize(1.0f);
            }
            
            GL.PointSize(1.0f);
            GL.LineWidth(1);
        }

        public void GetCurrentABLine(vec3 pivot, vec3 steer)
        {
            //move the ABLine over based on the overlap amount set in vehicle
            double widthMinusOverlap = mf.tool.toolWidth - mf.tool.toolOverlap;

            //x2-x1
            double dx = refABLineP2.easting - refABLineP1.easting;
            //z2-z1
            double dy = refABLineP2.northing - refABLineP1.northing;

            //how far are we away from the reference line at 90 degrees
            distanceFromRefLine = ((dy * steer.easting) - (dx * steer.northing) + (refABLineP2.easting
                                    * refABLineP1.northing) - (refABLineP2.northing * refABLineP1.easting))
                                        / Math.Sqrt((dy * dy) + (dx * dx));

            //if > 1.57 its going the opposite heading as refAB
            abFixHeadingDelta = (Math.Abs(mf.fixHeading - abHeading));
            if (abFixHeadingDelta >= Math.PI) abFixHeadingDelta = Math.Abs(abFixHeadingDelta - glm.twoPI);

            isABSameAsVehicleHeading = abFixHeadingDelta < glm.PIBy2;

            //absolute the distance
            //distanceFromRefLine = Math.Abs(distanceFromRefLine);

            //Which ABLine is the vehicle on, negative is left and positive is right side
            howManyPathsAway = Math.Round(distanceFromRefLine / widthMinusOverlap, 0, MidpointRounding.AwayFromZero);

            //generate that pass number as signed integer
            passNumber = Convert.ToInt32(howManyPathsAway);

            //calculate the new point that is number of implement widths over
            double toolOffset = mf.tool.toolOffset;
            vec2 point1;

            //depending which way you are going, the offset can be either side
            if (isABSameAsVehicleHeading)
            {
                point1 = new vec2((Math.Cos(-abHeading) * ((widthMinusOverlap * howManyPathsAway) - toolOffset)) + refPoint1.easting,
                (Math.Sin(-abHeading) * ((widthMinusOverlap * howManyPathsAway) - toolOffset)) + refPoint1.northing);
            }
            else
            {
                point1 = new vec2((Math.Cos(-abHeading) * ((widthMinusOverlap * howManyPathsAway) + toolOffset)) + refPoint1.easting,
                    (Math.Sin(-abHeading) * ((widthMinusOverlap * howManyPathsAway) + toolOffset)) + refPoint1.northing);
            }

            //create the new line extent points for current ABLine based on original heading of AB line
            currentABLineP1.easting = point1.easting - (Math.Sin(abHeading) * 1600.0);
            currentABLineP1.northing = point1.northing - (Math.Cos(abHeading) * 1600.0);

            currentABLineP2.easting = point1.easting + (Math.Sin(abHeading) * 1600.0);
            currentABLineP2.northing = point1.northing + (Math.Cos(abHeading) * 1600.0);

            //get the distance from currently active AB line
            //x2-x1
            dx = currentABLineP2.easting - currentABLineP1.easting;
            //z2-z1
            dy = currentABLineP2.northing - currentABLineP1.northing;

            //how far from current AB Line is steer point
            distanceFromCurrentLine = ((dy * steer.easting) - (dx * steer.northing) + (currentABLineP2.easting
                        * currentABLineP1.northing) - (currentABLineP2.northing * currentABLineP1.easting))
                        / Math.Sqrt((dy * dy) + (dx * dx));

            //are we on the right side or not
            isOnRightSideCurrentLine = distanceFromCurrentLine > 0;

            // **Stanley Point ** - calc point on ABLine closest to current steer position
            double U = (((steer.easting - currentABLineP1.easting) * dx)
                        + ((steer.northing - currentABLineP1.northing) * dy))
                        / ((dx * dx) + (dy * dy));

            //point on AB line closest to steer axle point
            rEastAB = currentABLineP1.easting + (U * dx);
            rNorthAB = currentABLineP1.northing + (U * dy);

            //distance is negative if on left, positive if on right
            if (isABSameAsVehicleHeading)
            {
                abFixHeadingDelta = (steer.heading - abHeading);
            }

            //opposite way so right is left
            else
            {
                abFixHeadingDelta = (steer.heading - abHeading + Math.PI);
                distanceFromCurrentLine *= -1.0;
            }

            //Fix the circular error
            if (abFixHeadingDelta > Math.PI) abFixHeadingDelta -= Math.PI;
            else if (abFixHeadingDelta < -Math.PI) abFixHeadingDelta += Math.PI;

            if (abFixHeadingDelta > glm.PIBy2) abFixHeadingDelta -= Math.PI;
            else if (abFixHeadingDelta < -glm.PIBy2) abFixHeadingDelta += Math.PI;

            abFixHeadingDelta *= mf.ast.stanleyHeadingErrorGain;

            avgDist = (1 - mf.ast.avgXTE) * distanceFromCurrentLine
                + (mf.ast.avgXTE) * avgDist;
            distanceFromCurrentLine = avgDist;
            distErr = Math.Abs(distanceFromCurrentLine);

            xTrackCorrection = Math.Atan((distanceFromCurrentLine * mf.ast.stanleyGain)
                / ((Math.Abs(mf.pn.speed * 0.277777)) + 2));

            if (mf.pn.speed > -0.1)
                steerAngleAB = glm.toDegrees((xTrackCorrection + abFixHeadingDelta) * -1.0);
            else
                steerAngleAB = glm.toDegrees((xTrackCorrection - abFixHeadingDelta) * -1.0);

            if (steerAngleAB < -mf.vehicle.maxSteerAngle) steerAngleAB = -mf.vehicle.maxSteerAngle;
            if (steerAngleAB > mf.vehicle.maxSteerAngle) steerAngleAB = mf.vehicle.maxSteerAngle;

            //Integral
            double deltaDeg = Math.Abs(glm.toDegrees(abFixHeadingDelta));
            double integralSpeed = (mf.pn.speed) / 10;

            if (deltaDeg < mf.ast.integralHeadingLimit && distErr < mf.ast.integralDistanceAway && mf.pn.speed > 0.5 && mf.isAutoSteerBtnOn)
            {
                if ((inty < 0 && distanceFromCurrentLine < 0) || (inty > 0 && distanceFromCurrentLine > 0))
                    inty += distanceFromCurrentLine * -mf.ast.stanleyIntegralGain * 3 * integralSpeed ;
                else inty += distanceFromCurrentLine * -mf.ast.stanleyIntegralGain 
                        * integralSpeed * ((mf.ast.integralHeadingLimit - deltaDeg)/ mf.ast.integralHeadingLimit);

                if (mf.ast.stanleyIntegralGain > 0) steerAngleAB += inty; 
                else inty = 0;
            }
            else
            {
                inty = 0;
            }

            //Convert to millimeters
            distanceFromCurrentLine = Math.Round(distanceFromCurrentLine * 1000.0, MidpointRounding.AwayFromZero);

            mf.guidanceLineDistanceOff = mf.distanceDisplay = (Int16)distanceFromCurrentLine;
            mf.guidanceLineSteerAngle = (Int16)(steerAngleAB * 100);
        }

        public double inty, distErr, xTrackCorrection, avgDist;

        public void MoveABLine(double dist)
        {
            double headingCalc;
            //calculate the heading 90 degrees to ref ABLine heading
            if (isABSameAsVehicleHeading)
            {
                headingCalc = abHeading + glm.PIBy2;
                moveDistance += dist;
            }
            else
            {
                headingCalc = abHeading - glm.PIBy2;
                moveDistance -= dist;
            }

            //calculate the new points for the reference line and points
            refPoint1.easting = (Math.Sin(headingCalc) * dist) + refPoint1.easting;
            refPoint1.northing = (Math.Cos(headingCalc) * dist) + refPoint1.northing;

            refABLineP1.easting = refPoint1.easting - (Math.Sin(abHeading) *   1600.0);
            refABLineP1.northing = refPoint1.northing - (Math.Cos(abHeading) * 1600.0);
                                                                                
            refABLineP2.easting = refPoint1.easting + (Math.Sin(abHeading) *   1600.0);
            refABLineP2.northing = refPoint1.northing + (Math.Cos(abHeading) * 1600.0);

            refPoint2.easting = refABLineP2.easting;
            refPoint2.northing = refABLineP2.northing;
        }

        public void DeleteAB()
        {
            refPoint1 = new vec2(0.0, 0.0);
            refPoint2 = new vec2(0.0, 1.0);

            refABLineP1 = new vec2(0.0, 0.0);
            refABLineP2 = new vec2(0.0, 1.0);

            currentABLineP1 = new vec2(0.0, 0.0);
            currentABLineP2 = new vec2(0.0, 1.0);

            abHeading = 0.0;
            passNumber = 0.0;
            howManyPathsAway = 0.0;
            isABLineSet = false;
            isABLineLoaded = false;
        }

        public void SetABLineByBPoint()
        {
            refPoint2.easting = mf.pn.fix.easting;
            refPoint2.northing = mf.pn.fix.northing;

            //calculate the AB Heading
            abHeading = Math.Atan2(refPoint2.easting - refPoint1.easting, refPoint2.northing - refPoint1.northing);
            if (abHeading < 0) abHeading += glm.twoPI;

            //sin x cos z for endpoints, opposite for additional lines
            refABLineP1.easting = refPoint1.easting - (Math.Sin(abHeading) *   1600.0);
            refABLineP1.northing = refPoint1.northing - (Math.Cos(abHeading) * 1600.0);

            refABLineP2.easting = refPoint1.easting + (Math.Sin(abHeading) *   1600.0);
            refABLineP2.northing = refPoint1.northing + (Math.Cos(abHeading) * 1600.0);

            isABLineSet = true;
            isABLineLoaded = true;
        }

        public void SetABLineByHeading()
        {
            //heading is set in the AB Form
            refABLineP1.easting = refPoint1.easting - (Math.Sin(abHeading) * 1600.0);
            refABLineP1.northing = refPoint1.northing - (Math.Cos(abHeading) * 1600.0);

            refABLineP2.easting = refPoint1.easting + (Math.Sin(abHeading) * 1600.0);
            refABLineP2.northing = refPoint1.northing + (Math.Cos(abHeading) * 1600.0);

            refPoint2.easting = refABLineP2.easting;
            refPoint2.northing = refABLineP2.northing;

            isABLineSet = true;
            isABLineLoaded = true;
        }

        public void SnapABLine()
        {
            double headingCalc;

            //calculate the heading 90 degrees to ref ABLine heading
            if (isOnRightSideCurrentLine)
            {
                headingCalc = abHeading + glm.PIBy2;
            }
            else
            {
                headingCalc = abHeading - glm.PIBy2;
            }

            if (isABSameAsVehicleHeading)
            {
                moveDistance += (distanceFromCurrentLine * 0.001);
            }
            else
            {
                moveDistance -= (distanceFromCurrentLine * 0.001);
            }


            //calculate the new points for the reference line and points
            refPoint1.easting = (Math.Sin(headingCalc) * Math.Abs(distanceFromCurrentLine) * 0.001) + refPoint1.easting;
            refPoint1.northing = (Math.Cos(headingCalc) * Math.Abs(distanceFromCurrentLine) * 0.001) + refPoint1.northing;

            refABLineP1.easting = refPoint1.easting - (Math.Sin(abHeading) *   1600.0);
            refABLineP1.northing = refPoint1.northing - (Math.Cos(abHeading) * 1600.0);

            refABLineP2.easting = refPoint1.easting + (Math.Sin(abHeading) *   1600.0);
            refABLineP2.northing = refPoint1.northing + (Math.Cos(abHeading) * 1600.0);

            refPoint2.easting = refABLineP2.easting;
            refPoint2.northing = refABLineP2.northing;
        }
    }

    public class CABLines
    {
        public vec2 ref1 = new vec2();
        public vec2 ref2 = new vec2();
        public vec2 origin = new vec2();
        public double heading = 0;
        public string Name = "aa";
    }
}