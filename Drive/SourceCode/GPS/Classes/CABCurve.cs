using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;

namespace Drive
{
    public class CABCurve
    {
        //pointers to mainform controls
        private readonly FormGPS mf;

        //flag for starting stop adding points
        public bool isBtnCurveOn, isOkToAddPoints, isCurveSet;

        public double distanceFromCurrentLine;
        public bool isABSameAsVehicleHeading = true;
        public bool isOnRightSideCurrentLine = true;

        public double howManyPathsAway, howManyPathsAwayPrevious, curveNumber;
        public vec2 refPoint1 = new vec2(1, 1), refPoint2 = new vec2(2, 2);

        public bool isSameWay, isSameWayPrevious, invalidateCurve;
        public double refHeading, moveDistance;
        public double deltaOfRefAndAveHeadings;

        //generated box for finding closest point
        public vec2 boxA = new vec2(0, 0), boxB = new vec2(0, 2);

        public vec2 boxC = new vec2(1, 1), boxD = new vec2(2, 3);
        private int A, B, C;
        public int currentLocationIndex;

        public double aveLineHeading;

        //pure pursuit values
        public vec2 goalPointCu = new vec2(0, 0);

        public vec2 radiusPointCu = new vec2(0, 0);
        public double steerAngleCu, rEastCu, rNorthCu, ppRadiusCu;

        //the list of points of the ref line.
        public List<vec3> refList = new List<vec3>();
        //the list of points of curve to drive on
        public List<vec3> curList = new List<vec3>();

        public bool isSmoothWindowOpen;
        public List<vec3> smooList = new List<vec3>();

        public List<CCurveLines> curveArr = new List<CCurveLines>();
        public int numCurveLines, numCurveLineSelected;

        public bool isEditing;
        public List<vec2> tramArr = new List<vec2>();
        public List<List<vec2>> tramList = new List<List<vec2>>();

        public CABCurve(FormGPS _f)
        {
            //constructor
            mf = _f;
        }

        public void DrawCurve()
        {
            if (!isEditing)
            {
                int ptCount = refList.Count;
                if (refList.Count == 0) return;
                GL.PointSize(2);
                GL.LineWidth(mf.ABLine.lineWidth);
                GL.Color3(0.96, 0.2f, 0.2f);
                GL.Begin(PrimitiveType.Points);
                for (int h = 0; h < ptCount; h++) GL.Vertex3(refList[h].easting, refList[h].northing, 0);
                if (!mf.curve.isCurveSet)
                {
                    GL.Color3(0.930f, 0.0692f, 0.260f);
                    ptCount--;
                    GL.Vertex3(refList[ptCount].easting, refList[ptCount].northing, 0);
                    GL.Vertex3(mf.pivotAxlePos.easting, mf.pivotAxlePos.northing, 0);
                }
                GL.End();

                if (mf.font.isFontOn && refList.Count > 4)
                {
                    GL.Color3(0.40f, 0.90f, 0.95f);
                    mf.font.DrawText3D(refList[0].easting, refList[0].northing, "&A");
                    mf.font.DrawText3D(refList[refList.Count - 1].easting, refList[refList.Count - 1].northing, "&B");
                }

                //just draw ref and smoothed line if smoothing window is open
                if (isSmoothWindowOpen)
                {
                    ptCount = smooList.Count;
                    if (smooList.Count == 0) return;

                    GL.LineWidth(mf.ABLine.lineWidth);
                    GL.Color3(0.930f, 0.92f, 0.260f);
                    GL.Begin(PrimitiveType.Lines);
                    for (int h = 0; h < ptCount; h++) GL.Vertex3(smooList[h].easting, smooList[h].northing, 0);
                    GL.End();
                }
                else //normal. Smoothing window is not open.
                {
                    ptCount = curList.Count;
                    if (ptCount > 0 && isCurveSet)
                    {
                        GL.PointSize(2);

                        //GL.Color3(0.95f, 0.2f, 0.95f);
                        //GL.Begin(PrimitiveType.LineStrip);
                        //for (int h = 0; h < ptCount; h++) GL.Vertex3(curList[h].easting, curList[h].northing, 0);
                        //GL.End();

                        GL.Color3(0.96, 0.82f, 0.62f);
                        GL.Begin(PrimitiveType.Points);
                        for (int h = 0; h < ptCount; h++) GL.Vertex3(curList[h].easting, curList[h].northing, 0);
                        GL.End();

                        GL.PointSize(4);
                        GL.Color3(0.96, 0.02f, 0.62f);
                        GL.Begin(PrimitiveType.Points);
                        GL.Vertex3(curList[A].easting, curList[A].northing, 0);
                        GL.Vertex3(curList[B].easting, curList[B].northing, 0);
                        GL.Color3(0.06, 0.902f, 0.42f);
                        GL.Vertex3(rEastCu, rNorthCu, 0);
                        GL.End();

                        if (mf.isPureDisplayOn && !mf.isStanleyUsed)
                        {
                            if (ppRadiusCu < 100 && ppRadiusCu > -100)
                            {
                                const int numSegments = 100;
                                double theta = glm.twoPI / numSegments;
                                double c = Math.Cos(theta);//precalculate the sine and cosine
                                double s = Math.Sin(theta);
                                double x = ppRadiusCu;//we start at angle = 0
                                double y = 0;

                                GL.LineWidth(1);
                                GL.Color3(0.95f, 0.30f, 0.950f);
                                GL.Begin(PrimitiveType.LineLoop);
                                for (int ii = 0; ii < numSegments; ii++)
                                {
                                    //glVertex2f(x + cx, y + cy);//output vertex
                                    GL.Vertex3(x + radiusPointCu.easting, y + radiusPointCu.northing, 0);//output vertex
                                    double t = x;//apply the rotation matrix
                                    x = (c * x) - (s * y);
                                    y = (s * t) + (c * y);
                                }
                                GL.End();
                            }

                            //Draw lookahead Point
                            GL.PointSize(4.0f);
                            GL.Begin(PrimitiveType.Points);
                            GL.Color3(1.0f, 0.5f, 0.95f);
                            GL.Vertex3(goalPointCu.easting, goalPointCu.northing, 0.0);
                            GL.End();
                        }
                    }
                }
                GL.PointSize(1.0f);
            }

            if (isEditing)
            {
                int ptCount = refList.Count;
                if (refList.Count == 0) return;

                GL.LineWidth(mf.ABLine.lineWidth);
                GL.Color3(0.930f, 0.2f, 0.260f);
                GL.Begin(PrimitiveType.Lines);
                for (int h = 0; h < ptCount; h++) GL.Vertex3(refList[h].easting, refList[h].northing, 0);
                GL.End();

                //current line
                if (curList.Count > 0 && isCurveSet)
                {
                    ptCount = curList.Count;
                    GL.Color3(0.95f, 0.2f, 0.950f);
                    GL.Begin(PrimitiveType.LineStrip);
                    for (int h = 0; h < ptCount; h++) GL.Vertex3(curList[h].easting, curList[h].northing, 0);
                    GL.End();
                }


                if (mf.camera.camSetDistance > -200)
                {
                    double toolWidth2 = mf.tool.toolWidth - mf.tool.toolOverlap;
                    double cosHeading2 = Math.Cos(-mf.curve.aveLineHeading);
                    double sinHeading2 = Math.Sin(-mf.curve.aveLineHeading);

                    GL.Color3(0.8f, 0.3f, 0.2f);
                    GL.PointSize(2);
                    GL.Begin(PrimitiveType.Points);


                    for (int i = 1; i <= 6; i++)
                    {
                        for (int h = 0; h < ptCount; h++)
                            GL.Vertex3((cosHeading2 * toolWidth2) + mf.curve.refList[h].easting,
                                          (sinHeading2 * toolWidth2) + mf.curve.refList[h].northing, 0);
                        toolWidth2 = toolWidth2 + mf.tool.toolWidth - mf.tool.toolOverlap;
                    }

                    GL.End();
                }
            }
        }

        //for calculating for display the averaged new line
        public void SmoothAB(int smPts)
        {
            //count the reference list of original curve
            int cnt = refList.Count;

            //just go back if not very long
            if (!isCurveSet || cnt < 400) return;

            //the temp array
            vec3[] arr = new vec3[cnt];

            //read the points before and after the setpoint
            for (int s = 0; s < smPts / 2; s++)
            {
                arr[s].easting = refList[s].easting;
                arr[s].northing = refList[s].northing;
                arr[s].heading = refList[s].heading;
            }

            for (int s = cnt - (smPts / 2); s < cnt; s++)
            {
                arr[s].easting = refList[s].easting;
                arr[s].northing = refList[s].northing;
                arr[s].heading = refList[s].heading;
            }

            //average them - center weighted average
            for (int i = smPts / 2; i < cnt - (smPts / 2); i++)
            {
                for (int j = -smPts / 2; j < smPts / 2; j++)
                {
                    arr[i].easting += refList[j + i].easting;
                    arr[i].northing += refList[j + i].northing;
                }
                arr[i].easting /= smPts;
                arr[i].northing /= smPts;
                arr[i].heading = refList[i].heading;
            }

            //make a list to draw
            smooList?.Clear();
            for (int i = 0; i < cnt; i++)
            {
                smooList.Add(arr[i]);
            }
        }

        public void CalculateTurnHeadings()
        {
            //to calc heading based on next and previous points to give an average heading.
            int cnt = refList.Count;
            if (cnt > 0)
            {
                vec3[] arr = new vec3[cnt];
                cnt--;
                refList.CopyTo(arr);
                refList.Clear();

                //middle points
                for (int i = 1; i < cnt; i++)
                {
                    vec3 pt3 = arr[i];
                    pt3.heading = Math.Atan2(arr[i + 1].easting - arr[i - 1].easting, arr[i + 1].northing - arr[i - 1].northing);
                    if (pt3.heading < 0) pt3.heading += glm.twoPI;
                    refList.Add(pt3);
                }
            }
        }

        //turning the visual line into the real reference line to use
        public void SaveSmoothAsRefList()
        {
            //oops no smooth list generated
            int cnt = smooList.Count;
            if (cnt == 0) return;

            //eek
            refList?.Clear();

            //copy to an array to calculate all the new headings
            vec3[] arr = new vec3[cnt];
            smooList.CopyTo(arr);

            //calculate new headings on smoothed line
            for (int i = 1; i < cnt - 1; i++)
            {
                arr[i].heading = Math.Atan2(arr[i + 1].easting - arr[i].easting, arr[i + 1].northing - arr[i].northing);
                if (arr[i].heading < 0) arr[i].heading += glm.twoPI;
                refList.Add(arr[i]);
            }
        }

        public void GetCurrentCurveLine(vec3 pivot, vec3 steer)
        {
            //vec2 p0 = new vec2(1, 0);
            //vec2 p1 = new vec2(3, 2);
            //vec2 p2 = new vec2(5, 3);
            //vec2 p3 = new vec2(6, 1);

            //vec2 a = 2.0 * p1;
            //vec2 b = p2 - p0;
            //vec2 c = 2.0 * p0 - 5.0 * p1 + 4.0 * p2 - p3;
            //vec2 d = -1.0 * p0 + 3.0 * p1 - 3.0 * p2 + p3;

            //double tt = 0.25;

            //vec2 pos = 0.5 * (a + (tt*b) + (tt * tt * c) + (tt * tt * tt * d));

            //move the ABLine over based on the overlap amount set in vehicle
            double widthMinusOverlap = mf.tool.toolWidth - mf.tool.toolOverlap;

            {
                int refCount = refList.Count;
                if (refCount < 5) return;
                double minDistA = 100000000, minDistB = 100000000;

                if (mf.mc.steerSwitchValue!=0)
                {

                    //find the closest 2 points to current fix
                    for (int t = 0; t < refCount; t++)
                    {
                        double dist = ((pivot.easting - refList[t].easting) * (pivot.easting - refList[t].easting))
                                        + ((pivot.northing - refList[t].northing) * (pivot.northing - refList[t].northing));
                        if (dist < minDistA)
                        {
                            minDistB = minDistA;
                            B = A;
                            minDistA = dist;
                            A = t;
                        }
                        else if (dist < minDistB)
                        {
                            minDistB = dist;
                            B = t;
                        }
                    }
                    if (A > B) { C = A; A = B; B = C; }

                    if (minDistA == 100000000 || minDistB == 100000000) return;

                    //same way a line creation or not
                    isSameWay = Math.PI - Math.Abs(Math.Abs(pivot.heading - refList[A].heading) - Math.PI) < glm.PIBy2;

                    //grab the heading at the closest point
                    refHeading = refList[A].heading;

                    //which side of the closest point are we on is next
                    //calculate endpoints of reference line based on closest point
                    refPoint1.easting = refList[A].easting - (Math.Sin(refHeading) * 2000.0);
                    refPoint1.northing = refList[A].northing - (Math.Cos(refHeading) * 2000.0);

                    refPoint2.easting = refList[A].easting + (Math.Sin(refHeading) * 2000.0);
                    refPoint2.northing = refList[A].northing + (Math.Cos(refHeading) * 2000.0);

                    //x2-x1
                    double dx = refPoint2.easting - refPoint1.easting;
                    //z2-z1
                    double dz = refPoint2.northing - refPoint1.northing;

                    //how far are we away from the reference line at 90 degrees - 2D cross product and distance
                    double distanceFromRefLine = ((dz * pivot.easting) - (dx * pivot.northing) + (refPoint2.easting
                                            * refPoint1.northing) - (refPoint2.northing * refPoint1.easting))
                                            / Math.Sqrt((dz * dz) + (dx * dx));

                    deltaOfRefAndAveHeadings = 1;


                    //add or subtract pi by 2 depending on which side of ref line
                    //move the ABLine over based on the overlap amount set in vehicle
                    if (mf.tool.toolOffset != 0)
                    {
                        widthMinusOverlap = mf.tool.toolWidth / 2 - mf.tool.toolOverlap;
                    }
                    else
                    {
                        widthMinusOverlap = mf.tool.toolWidth - mf.tool.toolOverlap;
                    }

                    //determine closest point to vehicle spacing
                    howManyPathsAway = Math.Round(distanceFromRefLine / widthMinusOverlap, 0, MidpointRounding.AwayFromZero);

                    //right or left
                    curveNumber = howManyPathsAway;
                    //if (distanceFromRefLine < 0) curveNumber = -curveNumber;
                }

                if (isSameWayPrevious != isSameWay || howManyPathsAway != howManyPathsAwayPrevious)
                {
                    isSameWayPrevious = isSameWay;
                    howManyPathsAwayPrevious = howManyPathsAway;

                    //build the current line
                    curList?.Clear();

                    double distSqAway = (widthMinusOverlap * howManyPathsAway * widthMinusOverlap * howManyPathsAway) * 0.999999;

                    if (isSameWay)
                    {
                        for (int i = 0; i < refCount - 1; i++)
                        {
                            var point = new vec3(
                            refList[i].easting + (Math.Sin(glm.PIBy2 + refList[i].heading) * widthMinusOverlap * howManyPathsAway),
                            refList[i].northing + (Math.Cos(glm.PIBy2 + refList[i].heading) * widthMinusOverlap * howManyPathsAway),
                            refList[i].heading);
                            bool Add = true;
                            for (int t = 0; t < refCount; t++)
                            {
                                double dist = ((point.easting - refList[t].easting) * (point.easting - refList[t].easting)) + ((point.northing - refList[t].northing) * (point.northing - refList[t].northing));
                                if (dist < distSqAway)
                                {
                                    Add = false;
                                    break;
                                }
                            }
                            if (Add)
                            {
                                if (curList.Count > 0)
                                {
                                    double dist = ((point.easting - curList[curList.Count - 1].easting) * (point.easting - curList[curList.Count - 1].easting)) + ((point.northing - curList[curList.Count - 1].northing) * (point.northing - curList[curList.Count - 1].northing));
                                    if (dist > 1)
                                        curList.Add(point);
                                }
                                else curList.Add(point);
                            }
                        }
                    }
                    else  //going opposite direction of refList creation
                    {
                        for (int i = refCount - 1; i >= 0; i--)
                        {
                            var point = new vec3(
                            refList[i].easting + (Math.Sin(glm.PIBy2 + refList[i].heading) * widthMinusOverlap * howManyPathsAway),
                            refList[i].northing + (Math.Cos(glm.PIBy2 + refList[i].heading) * widthMinusOverlap * howManyPathsAway),
                            refList[i].heading);
                            bool Add = true;
                            for (int t = refCount-1; t >= 0; t--)
                            {
                                double dist = ((point.easting - refList[t].easting) * (point.easting - refList[t].easting)) + ((point.northing - refList[t].northing) * (point.northing - refList[t].northing));
                                if (dist < distSqAway)
                                {
                                    Add = false;
                                    break;
                                }
                            }
                            if (Add)
                            {
                                if (curList.Count > 0)
                                {
                                    double dist = ((point.easting - curList[curList.Count - 1].easting) * (point.easting - curList[curList.Count - 1].easting)) + ((point.northing - curList[curList.Count - 1].northing) * (point.northing - curList[curList.Count - 1].northing));
                                    if (dist > 1)
                                        curList.Add(point);
                                }
                                else curList.Add(point);
                            }
                        }
                    }

                    int cnt = curList.Count;
                    if (cnt > 6)
                    {
                        vec3[] arr = new vec3[cnt];
                        curList.CopyTo(arr);

                        for (int i = 1; i < (curList.Count - 1); i++)
                        {
                            arr[i].easting = (curList[i - 1].easting + curList[i].easting + curList[i + 1].easting) / 3;
                            arr[i].northing = (curList[i - 1].northing + curList[i].northing + curList[i + 1].northing) / 3;
                        }
                        curList.Clear();

                        for (int i = 0; i < (arr.Length-1); i++)
                        {
                            arr[i].heading = Math.Atan2(arr[i + 1].easting - arr[i].easting, arr[i + 1].northing - arr[i].northing);
                            if (arr[i].heading < 0) arr[i].heading += glm.twoPI;
                            if (arr[i].heading >= glm.twoPI) arr[i].heading -= glm.twoPI;
                        }

                        arr[arr.Length - 1].heading = arr[arr.Length - 2].heading;


                        if (mf.tool.isToolTrailing)
                        {
                            //depending on hitch is different profile of draft
                            double hitch;
                            if (mf.tool.isToolTBT && mf.tool.toolTankTrailingHitchLength < 0)
                            {
                                hitch = mf.tool.toolTankTrailingHitchLength * 0.85;
                                hitch += mf.tool.toolTrailingHitchLength * 0.65;
                            }
                            else hitch = mf.tool.toolTrailingHitchLength * 1.0;// - mf.vehicle.wheelbase;

                            //move the line forward based on hitch length ratio
                            for (int i = 0; i < arr.Length; i++)
                            {
                                arr[i].easting -= Math.Sin(arr[i].heading) * (hitch);
                                arr[i].northing -= Math.Cos(arr[i].heading) * (hitch);
                            }

                            ////average the points over 3, center weighted
                            //for (int i = 1; i < arr.Length - 2; i++)
                            //{
                            //    arr2[i].easting = (arr[i - 1].easting + arr[i].easting + arr[i + 1].easting) / 3;
                            //    arr2[i].northing = (arr[i - 1].northing + arr[i].northing + arr[i + 1].northing) / 3;
                            //}

                            //recalculate the heading
                            for (int i = 0; i < (arr.Length-1); i++)
                            {
                                arr[i].heading = Math.Atan2(arr[i + 1].easting - arr[i].easting, arr[i + 1].northing - arr[i].northing);
                                if (arr[i].heading < 0) arr[i].heading += glm.twoPI;
                                if (arr[i].heading >= glm.twoPI) arr[i].heading -= glm.twoPI;
                            }

                            arr[arr.Length - 1].heading = arr[arr.Length - 2].heading;
                        }

                        //replace the array 
                        curList.AddRange(arr);
                    }

                    //add the tails to boundary
                    if (mf.bnd.bndArr.Count > 0)
                    {
                        AddFirstPointsToCurList();
                        AddLastPointsToCurList();
                    }
                    else
                    {
                        AddFirstPointsToCurListNoBnd();
                        AddLastPointsToCurListNoBnd();
                    }
                }
            }

            int ptCount = curList.Count;
            if (ptCount > 0)
            {
                double minDistA = 1000000, minDistB = 1000000;
                    //find the closest 2 points to current fix
                    for (int j = 0; j < ptCount; j++)
                    {
                        double dist = ((steer.easting - curList[j].easting) * (steer.easting - curList[j].easting))
                                        + ((steer.northing - curList[j].northing) * (steer.northing - curList[j].northing));
                        if (dist < minDistA)
                        {
                            minDistB = minDistA;
                            B = A;
                            minDistA = dist;
                            A = j;
                        }
                        else if (dist < minDistB)
                        {
                            minDistB = dist;
                            B = j;
                        }
                    }

                    //just need to make sure the points continue ascending or heading switches all over the place
                    if (A > B) { C = A; A = B; B = C; }

                    currentLocationIndex = A;

                    //get the distance from currently active AB line
                    double dx = curList[B].easting - curList[A].easting;
                    double dz = curList[B].northing - curList[A].northing;

                    if (Math.Abs(dx) < Double.Epsilon && Math.Abs(dz) < Double.Epsilon) return;

                    //abHeading = Math.Atan2(dz, dx);
                    double abHeading = curList[A].heading;

                    //how far from current AB Line is fix
                    distanceFromCurrentLine = ((dz * steer.easting) - (dx * steer.northing) + (curList[B].easting
                                * curList[A].northing) - (curList[B].northing * curList[A].easting))
                                    / Math.Sqrt((dz * dz) + (dx * dx));

                    //are we on the right side or not
                    isOnRightSideCurrentLine = distanceFromCurrentLine > 0;

                    //absolute the distance
                    distanceFromCurrentLine = Math.Abs(distanceFromCurrentLine);

                    //Subtract the two headings, if > 1.57 its going the opposite heading as refAB
                    double abFixHeadingDelta = (Math.Abs(mf.fixHeading - abHeading));
                    if (abFixHeadingDelta >= Math.PI) abFixHeadingDelta = Math.Abs(abFixHeadingDelta - glm.twoPI);
                    isABSameAsVehicleHeading = abFixHeadingDelta < glm.PIBy2;

                    // calc point on ABLine closest to current position
                    double U = (((steer.easting - curList[A].easting) * dx)
                                + ((steer.northing - curList[A].northing) * dz))
                                / ((dx * dx) + (dz * dz));

                    rEastCu = curList[A].easting + (U * dx);
                    rNorthCu = curList[A].northing + (U * dz);

                    //double distPt = glm.Distance(curList[A], rEastCu, rNorthCu);
                    //double distab = glm.Distance(curList[A], curList[B]);
                    //double t = distPt / distab;


                    //distance is negative if on left, positive if on right
                    if (isABSameAsVehicleHeading)
                    {
                        if (!isOnRightSideCurrentLine)
                        {
                            distanceFromCurrentLine *= -1.0;
                        }
                        abFixHeadingDelta = (steer.heading - abHeading);
                    }

                    //opposite way so right is left
                    else
                    {
                        if (isOnRightSideCurrentLine)
                        {
                            distanceFromCurrentLine *= -1.0;
                        }
                        abFixHeadingDelta = (steer.heading - abHeading + Math.PI);
                    }

                    //Fix the circular error
                    if (abFixHeadingDelta > Math.PI) abFixHeadingDelta -= Math.PI;
                    else if (abFixHeadingDelta < Math.PI) abFixHeadingDelta += Math.PI;

                    if (abFixHeadingDelta > glm.PIBy2) abFixHeadingDelta -= Math.PI;
                    else if (abFixHeadingDelta < -glm.PIBy2) abFixHeadingDelta += Math.PI;

                    abFixHeadingDelta *= mf.ast.stanleyHeadingErrorGain;

                    steerAngleCu = Math.Atan((distanceFromCurrentLine * mf.ast.stanleyGain) 
                        / ((Math.Abs(mf.pn.speed) * 0.277777) + 1));

                    if (mf.pn.speed > -0.1)
                        steerAngleCu = glm.toDegrees((steerAngleCu + abFixHeadingDelta) * -1.0);
                    else
                        steerAngleCu = glm.toDegrees((steerAngleCu - abFixHeadingDelta) * -1.0);

                    if (steerAngleCu < -mf.vehicle.maxSteerAngle) steerAngleCu = -mf.vehicle.maxSteerAngle;
                    if (steerAngleCu > mf.vehicle.maxSteerAngle) steerAngleCu = mf.vehicle.maxSteerAngle;

                    //Convert to millimeters
                    distanceFromCurrentLine = Math.Round(distanceFromCurrentLine * 1000.0, MidpointRounding.AwayFromZero);
                

                mf.guidanceLineDistanceOff = mf.distanceDisplay = (Int16)distanceFromCurrentLine;
                mf.guidanceLineSteerAngle = (Int16)(steerAngleCu * 100);
            }
            else
            {
                //invalid distance so tell AS module
                distanceFromCurrentLine = 32000;
                mf.guidanceLineDistanceOff = 32000;
            }
        }

        public void SnapABCurve()
        {
            double headingAt90;

            //calculate the heading 90 degrees to ref ABLine heading
            if (isOnRightSideCurrentLine)
            {
                headingAt90 = glm.PIBy2;
            }
            else
            {
                headingAt90 = -glm.PIBy2;
            }

            if (isABSameAsVehicleHeading)
            {
                moveDistance += distanceFromCurrentLine * 0.001;
            }
            else
            {
                moveDistance -= distanceFromCurrentLine * 0.001;
            }


            int cnt = refList.Count;
            vec3[] arr = new vec3[cnt];
            refList.CopyTo(arr);
            refList.Clear();

            for (int i = 0; i < cnt; i++)
            {
                arr[i].easting = (Math.Sin(headingAt90 + arr[i].heading) * Math.Abs(distanceFromCurrentLine) * 0.001) + arr[i].easting;
                arr[i].northing = (Math.Cos(headingAt90 + arr[i].heading) * Math.Abs(distanceFromCurrentLine) * 0.001) + arr[i].northing;
                refList.Add(arr[i]);
            }
        }

        public void MoveABCurve(double dist)
        {
            double headingAt90;

            //calculate the heading 90 degrees to ref ABLine heading

            if (isABSameAsVehicleHeading)
            {
                headingAt90 = glm.PIBy2;
                moveDistance += dist;
            }
            else
            {
                headingAt90 = -glm.PIBy2;
                moveDistance -= dist;
            }

            int cnt = refList.Count;
            vec3[] arr = new vec3[cnt];
            refList.CopyTo(arr);
            refList.Clear();

            for (int i = 0; i < cnt; i++)
            {
                arr[i].easting = (Math.Sin(headingAt90 + arr[i].heading) * dist) + arr[i].easting;
                arr[i].northing = (Math.Cos(headingAt90 + arr[i].heading) * dist) + arr[i].northing;
                refList.Add(arr[i]);
            }
        }

        public bool PointOnLine(vec3 pt1, vec3 pt2, vec3 pt)
        {
            var r = new vec2(0, 0);
            if (pt1.northing == pt2.northing && pt1.easting == pt2.easting) { pt1.northing -= 0.00001; }

            var U = ((pt.northing - pt1.northing) * (pt2.northing - pt1.northing)) + ((pt.easting - pt1.easting) * (pt2.easting - pt1.easting));

            var Udenom = Math.Pow(pt2.northing - pt1.northing, 2) + Math.Pow(pt2.easting - pt1.easting, 2);

            U /= Udenom;

            r.northing = pt1.northing + (U * (pt2.northing - pt1.northing));
            r.easting = pt1.easting + (U * (pt2.easting - pt1.easting));

            double minx, maxx, miny, maxy;

            minx = Math.Min(pt1.northing, pt2.northing);
            maxx = Math.Max(pt1.northing, pt2.northing);

            miny = Math.Min(pt1.easting, pt2.easting);
            maxy = Math.Max(pt1.easting, pt2.easting);
            return _ = r.northing >= minx && r.northing <= maxx && (r.easting >= miny && r.easting <= maxy);
        }

        //add extensons
        public void AddFirstLastPoints(int numPoints)
        {
            int ptCnt = refList.Count - 1;
            for (int i = 1; i < numPoints; i++)
            {
                vec3 pt = new vec3(refList[ptCnt]);
                pt.easting += (Math.Sin(pt.heading) * (double)(i) / 2);
                pt.northing += (Math.Cos(pt.heading) * (double)(i) / 2);
                refList.Add(pt);
            }

            //and the beginning
            vec3 start = new vec3(refList[0]);
            for (int i = 1; i < numPoints; i++)
            {
                vec3 pt = new vec3(start);
                pt.easting -= (Math.Sin(pt.heading) * (double)(i) / 2);
                pt.northing -= (Math.Cos(pt.heading) * (double)(i) / 2);
                refList.Insert(0, pt);
            }
        }

        public void AddFirstPointsToCurList()
        {
            vec3 start = new vec3(curList[0]);

            while (mf.bnd.bndArr[0].IsPointInsideBoundary(start))
            {

                for (int i = 1; i < 10; i++)
                {
                    vec3 pt = new vec3(start);
                    pt.easting -= (Math.Sin(pt.heading) * i);
                    pt.northing -= (Math.Cos(pt.heading) * i);
                    curList.Insert(0, pt);
                }

                start = new vec3(curList[0]);
            }
        }

        public void AddLastPointsToCurList()
        {
            int ptCnt = curList.Count - 1;

            vec3 pt = new vec3(curList[ptCnt]);

            while (mf.bnd.bndArr[0].IsPointInsideBoundary(pt))

            {
                for (int i = 1; i < 10; i++)
                {
                    pt = new vec3(curList[ptCnt]);
                    pt.easting += (Math.Sin(pt.heading) * i);
                    pt.northing += (Math.Cos(pt.heading) * i);
                    curList.Add(pt);
                }
                ptCnt = curList.Count - 1;
            }
        }

        public void AddFirstPointsToCurListNoBnd()
        {
            vec3 start = new vec3(curList[0]);

            for (int i = 1; i < 100; i++)
            {
                vec3 pt = new vec3(start);
                pt.easting -= (Math.Sin(pt.heading) * i);
                pt.northing -= (Math.Cos(pt.heading) * i);
                curList.Insert(0, pt);
            }
        }

        public void AddLastPointsToCurListNoBnd()
        {
            int ptCnt = curList.Count - 1;

            vec3 pt = new vec3(curList[ptCnt]);

            for (int i = 1; i < 100; i++)
            {
                pt = new vec3(curList[ptCnt]);
                pt.easting += (Math.Sin(pt.heading) * i);
                pt.northing += (Math.Cos(pt.heading) * i);
                curList.Add(pt);
            }
        }


        public void ResetCurveLine()
        {
            curList?.Clear();
            refList?.Clear();
            isCurveSet = false;
            isOkToAddPoints = false;
        }

        ////draw the guidance line
    }

    public class CCurveLines
    {
        public List<vec3> curvePts = new List<vec3>();
        public double aveHeading = 3;
        public string Name = "aa";
        //public bool spiralmode = false;
        //public bool circlemode = false;
    }

}