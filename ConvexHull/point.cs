/*
	@ masphei
	email : masphei@gmail.com
*/
// --------------------------------------------------------------------------
// 2016-05-11 <oss.devel@searchathing.com> : created csprj and splitted Main into a separate file
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace ConvexHull
{

    public class Point
    {
        private int y;
        private int x;
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
    }
    
    // Helper class to let us easily pass list of points from AHK to C#
    public class PointsList
    {
        public List<Point> Points { get; }

        public PointsList()
        {
            Points = new List<Point>();
        }

        public void Add(int x, int y)
        {
            Points.Add(new Point(x, y));
        }

        public int Test()
        {
            return Points[0].getX();
        }
    }
}