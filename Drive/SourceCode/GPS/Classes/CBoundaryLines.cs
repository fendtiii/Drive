using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;

namespace Drive
{
    //public class vec3
    //{
    //    public double easting { get; set; }
    //    public double northing { get; set; }
    //    public double heading { get; set; }

    //    //constructor
    //    public vec3(double _easting, double _northing, double _heading)
    //    {
    //        easting = _easting;
    //        northing = _northing;
    //        heading = _heading;
    //    }
    //}

    public class CBoundaryLines
    {
        //constructor
        public CBoundaryLines()
        {
            area = 0;
            isSet = false;
            isDriveAround = false;
            isDriveThru = false;
        }

        //list of coordinates of boundary line
        public List<vec3> bndLine = new List<vec3>();

        //the list of constants and multiples of the boundary
        public List<vec2> calcList = new List<vec2>();

        //area variable
        public double area;

        //boundary variables
        public bool isSet, isDriveAround, isDriveThru;

        public void CalculateBoundaryHeadings()
        {
            //to calc heading based on next and previous points to give an average heading.
            int cnt = bndLine.Count;
            vec3[] arr = new vec3[cnt];
            cnt--;
            bndLine.CopyTo(arr);
            bndLine.Clear();

            //first point needs last, first, second points
            vec3 pt3 = arr[0];
            pt3.heading = Math.Atan2(arr[1].easting - arr[cnt].easting, arr[1].northing - arr[cnt].northing);
            if (pt3.heading < 0) pt3.heading += glm.twoPI;
            bndLine.Add(pt3);

            //middle points
            for (int i = 1; i < cnt; i++)
            {
                pt3 = arr[i];
                pt3.heading = Math.Atan2(arr[i + 1].easting - arr[i - 1].easting, arr[i + 1].northing - arr[i - 1].northing);
                if (pt3.heading < 0) pt3.heading += glm.twoPI;
                bndLine.Add(pt3);
            }

            //last and first point
            pt3 = arr[cnt];
            pt3.heading = Math.Atan2(arr[0].easting - arr[cnt - 1].easting, arr[0].northing - arr[cnt - 1].northing);
            if (pt3.heading < 0) pt3.heading += glm.twoPI;
            bndLine.Add(pt3);
        }

        private int ClampListPos(int pos, vec3[] arr)
        {
            if (pos < 0)
            {
                pos = arr.Length - 1;
            }

            if (pos > arr.Length)
            {
                pos = 1;
            }
            else if (pos > arr.Length - 1)
            {
                pos = 0;
            }

            return pos;
        }

        public void FixBoundaryLine(int bndNum)
        {
            //count the points from the boundary
            int ptCount = bndLine.Count;

            //quick area test
            CalculateBoundaryArea();

            double spacing;

            //close if less then 30 ha
            if (area < 300000) spacing = 0.5;
            else if (area < 600000) spacing = 1.0;
            else spacing = 2.0;

            //first find out which side is inside the boundary
            double oneSide = glm.PIBy2;
            vec3 point = new vec3(bndLine[2].easting - (Math.Sin(oneSide + bndLine[2].heading) * 2.0),
            bndLine[2].northing - (Math.Cos(oneSide + bndLine[2].heading) * 2.0), 0.0);

            //make sure boundaries are wound correctly
            if (bndNum == 0)
            {
                //outside an outer boundary means its wound clockwise
                if (!IsPointInsideBoundary(point)) ReverseWinding();
            }
            else
            {
                //inside an inner boundary means its wound clockwise
                if (IsPointInsideBoundary(point)) ReverseWinding();
                spacing = 0.5;
            }

            //make sure distance isn't too small between points on boundary
            int bndCount = bndLine.Count;
            double distance;
            for (int i = 0; i < bndCount - 1; i++)
            {
                distance = glm.Distance(bndLine[i], bndLine[i + 1]);
                if (distance < spacing*0.5)
                {
                    bndLine.RemoveAt(i + 1);
                    bndCount = bndLine.Count;
                    i--;
                }
            }

            //make sure distance isn't too big between points on boundary
            bndCount = bndLine.Count;

            for (int i = 0; i < bndCount; i++)
            {
                int j = i + 1;

                if (j == bndCount) j = 0;
                distance = glm.DistanceSquared(bndLine[i], bndLine[j]);
                if (distance > 12)
                {
                    vec3 pointB = new vec3((bndLine[i].easting + bndLine[j].easting) / 2.0,
                        (bndLine[i].northing + bndLine[j].northing) / 2.0, bndLine[i].heading);

                    bndLine.Insert(j, pointB);
                    bndCount = bndLine.Count;
                    i--;
                }
            }

            bndCount = bndLine.Count;

            for (int i = 0; i < bndCount; i++)
            {
                int j = i + 1;

                if (j == bndCount) j = 0;
                distance = glm.DistanceSquared(bndLine[i], bndLine[j]);
                if (distance > 14)
                {
                    vec3 pointB = new vec3((bndLine[i].easting + bndLine[j].easting) / 2.0,
                        (bndLine[i].northing + bndLine[j].northing) / 2.0, bndLine[i].heading);

                    bndLine.Insert(j, pointB);
                    bndCount = bndLine.Count;
                    i = 0;
                }
            }


            ////make sure distance isn't too big between points on boundary

            int cnt = bndLine.Count;
            vec3[] arr = new vec3[cnt];
            bndLine.CopyTo(arr);
            bndLine.Clear();

            //add the first point of loop - it will be p1
            bndLine.Add(arr[0]);

            //use the last loop point as p0 - distance between p1 and p2 is arr[0] and arr[1]
            distance = glm.Distance(arr[0], arr[1]);

            // fill in spline points if small spacing
            if (distance > spacing)
            {
                int loopTimes = (int)(distance / spacing + 2);
                for (int j = 1; j < loopTimes; j++)
                {
                    vec3 pos = new vec3(glm.Catmull(j / (double)(loopTimes), arr[cnt - 1], arr[0], arr[1], arr[2]));
                    bndLine.Add(pos);
                }
            }

            //bndLine.Add(arr[1]);

            //do all the points in between
            for (int i = 0; i < cnt - 3; i++)
            {
                // add p1
                bndLine.Add(arr[i + 1]);

                distance = glm.Distance(arr[i + 1], arr[i + 2]);

                if (distance > spacing)
                {
                    int loopTimes = (int)(distance / spacing + 2);
                    for (int j = 1; j < loopTimes; j++)
                    {
                        vec3 pos = new vec3(glm.Catmull(j / (double)(loopTimes), arr[i], arr[i + 1], arr[i + 2], arr[i + 3]));
                        bndLine.Add(pos);
                    }
                }
            }

            bndLine.Add(arr[cnt - 2]);

            //second last to last point
            distance = glm.Distance(arr[cnt - 1], arr[cnt - 2]);

            // fill in spline points if small spacing
            if (distance > spacing)
            {
                int loopTimes = (int)(distance / spacing + 2);
                for (int j = 1; j < loopTimes; j++)
                {
                    vec3 pos = new vec3(glm.Catmull(j / (double)(loopTimes), arr[cnt - 3], arr[cnt - 2], arr[cnt - 1], arr[0]));
                    bndLine.Add(pos);
                }

            }

            //add last point
            bndLine.Add(arr[cnt - 1]);

            //last to first point
            distance = glm.Distance(arr[cnt - 1], arr[0]);

            // fill in spline points if small spacing
            if (distance > spacing)
            {
                int loopTimes = (int)(distance / spacing + 2);
                for (int j = 1; j < loopTimes; j++)
                {
                    vec3 pos = new vec3(glm.Catmull(j / (double)(loopTimes), arr[cnt - 2], arr[cnt - 1], arr[0], arr[1]));
                    bndLine.Add(pos);
                }
            }

            //make sure headings are correct for calculated points
            CalculateBoundaryHeadings();
        }

        private void ReverseWinding()
        {
            //reverse the boundary
            int cnt = bndLine.Count;
            vec3[] arr = new vec3[cnt];
            cnt--;
            bndLine.CopyTo(arr);
            bndLine.Clear();
            for (int i = cnt; i >= 0; i--)
            {
                arr[i].heading -= Math.PI;
                if (arr[i].heading < 0) arr[i].heading += glm.twoPI;
                bndLine.Add(arr[i]);
            }
        }

        public void PreCalcBoundaryLines()
        {
            int j = bndLine.Count - 1;
            //clear the list, constant is easting, multiple is northing
            calcList.Clear();
            vec2 constantMultiple = new vec2(0, 0);

            for (int i = 0; i < bndLine.Count; j = i++)
            {
                //check for divide by zero
                if (Math.Abs(bndLine[i].northing - bndLine[j].northing) < 0.00000000001)
                {
                    constantMultiple.easting = bndLine[i].easting;
                    constantMultiple.northing = 0;
                    calcList.Add(constantMultiple);
                }
                else
                {
                    //determine constant and multiple and add to list
                    constantMultiple.easting = bndLine[i].easting - ((bndLine[i].northing * bndLine[j].easting)
                                    / (bndLine[j].northing - bndLine[i].northing)) + ((bndLine[i].northing * bndLine[i].easting)
                                        / (bndLine[j].northing - bndLine[i].northing));
                    constantMultiple.northing = (bndLine[j].easting - bndLine[i].easting) / (bndLine[j].northing - bndLine[i].northing);
                    calcList.Add(constantMultiple);
                }
            }
        }

        public bool IsPointInsideBoundary(vec3 testPointv3)
        {
            if (calcList.Count < 3) return false;
            int j = bndLine.Count - 1;
            bool oddNodes = false;

            //test against the constant and multiples list the test point
            for (int i = 0; i < bndLine.Count; j = i++)
            {
                if ((bndLine[i].northing < testPointv3.northing && bndLine[j].northing >= testPointv3.northing)
                || (bndLine[j].northing < testPointv3.northing && bndLine[i].northing >= testPointv3.northing))
                {
                    oddNodes ^= ((testPointv3.northing * calcList[i].northing) + calcList[i].easting < testPointv3.easting);
                }
            }
            return oddNodes; //true means inside.
        }

        public bool IsPointInsideBoundary(vec2 testPointv2)
        {
            if (calcList.Count < 3) return false;
            int j = bndLine.Count - 1;
            bool oddNodes = false;

            //test against the constant and multiples list the test point
            for (int i = 0; i < bndLine.Count; j = i++)
            {
                if ((bndLine[i].northing < testPointv2.northing && bndLine[j].northing >= testPointv2.northing)
                || (bndLine[j].northing < testPointv2.northing && bndLine[i].northing >= testPointv2.northing))
                {
                    oddNodes ^= ((testPointv2.northing * calcList[i].northing) + calcList[i].easting < testPointv2.easting);
                }
            }
            return oddNodes; //true means inside.
        }

        public void DrawBoundaryLine()
        {
            ////draw the perimeter line so far
            if (bndLine.Count < 1) return;
            //GL.PointSize(2);
            GL.LineWidth(2);
            int ptCount = bndLine.Count;
            //if (isDriveThru) GL.Color3(0.25f, 0.752f, 0.860f);
            //else 
            GL.Begin(PrimitiveType.LineLoop);
            for (int h = 0; h < ptCount; h++) GL.Vertex3(bndLine[h].easting, bndLine[h].northing, 0);
            //GL.Color3(0.95f, 0.972f, 0.90f);
            //GL.Vertex3(bndLine[0].easting, bndLine[0].northing, 0);
            GL.End();

            if (ptCount < 1) return;
            GL.PointSize(4);
            GL.Color3(0.19f, 0.932f, 0.70f);
            GL.Begin(PrimitiveType.Points);
            for (int h = 0; h < ptCount; h++) GL.Vertex3(bndLine[h].easting, bndLine[h].northing, 0);
            GL.End();
        }

        //obvious
        public void CalculateBoundaryArea()
        {
            int ptCount = bndLine.Count;
            if (ptCount < 1) return;

            area = 0;         // Accumulates area in the loop
            int j = ptCount - 1;  // The last vertex is the 'previous' one to the first

            for (int i = 0; i < ptCount; j = i++)
            {
                area += (bndLine[j].easting + bndLine[i].easting) * (bndLine[j].northing - bndLine[i].northing);
            }
            area = Math.Abs(area / 2);
        }
    }
}