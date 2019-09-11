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

    public class JarvisMatch
    {
        const int TURN_LEFT = 1;
        const int TURN_RIGHT = -1;
        const int TURN_NONE = 0;
        public int turn(Point p, Point q, Point r)
        {
            return ((q.X - p.X) * (r.Y - p.Y) - (r.X - p.X) * (q.Y - p.Y)).CompareTo(0);
        }

        public int dist(Point p, Point q)
        {
            int dx = q.X - p.X;
            int dy = q.Y - p.Y;
            return dx * dx + dy * dy;
        }

        public Point nextHullPoint(List<Point> points, Point p)
        {
            Point q = p;
            int t;
            foreach (Point r in points)
            {
                t = turn(p, q, r);
                if (t == TURN_RIGHT || t == TURN_NONE && dist(p, r) > dist(p, q))
                    q = r;
            }
            return q;
        }

        public double getAngle(Point p1, Point p2)
        {
            float xDiff = p2.X - p1.X;
            float yDiff = p2.Y - p1.Y;
            return Math.Atan2(yDiff, xDiff) * 180.0 / Math.PI;
        }

        public void convexHull(List<Point> points)
        {
            Console.WriteLine("# List of Point #");
            foreach (Point value in points)
            {
                Console.Write("(" + value.X + "," + value.Y + ") ");
            }
            Console.WriteLine();
            Console.WriteLine();
            List<Point> hull = new List<Point>();
            foreach (Point p in points)
            {
                if (hull.Count == 0)
                    hull.Add(p);
                else
                {
                    if (hull[0].X > p.X)
                        hull[0] = p;
                    else if (hull[0].X == p.X)
                        if (hull[0].Y > p.Y)
                            hull[0] = p;
                }
            }
            Point q;
            int counter = 0;
            Console.WriteLine("The lowest point is (" + hull[0].X + ", " + hull[0].Y + ")");
            while (counter < hull.Count)
            {
                q = nextHullPoint(points, hull[counter]);
                if (q != hull[0])
                {
                    Console.WriteLine("Next Point is (" + q.X + "," + q.Y + ") compared to Point (" + hull[hull.Count - 1].X + "," + hull[hull.Count - 1].Y + ") : " + getAngle(hull[hull.Count - 1], q) + " degrees");
                    hull.Add(q);
                }
                counter++;
            }
            Console.WriteLine();
            Console.WriteLine("# Convex Hull #");
            foreach (Point value in hull)
            {
                Console.Write("(" + value.X + "," + value.Y + ") ");
            }
            Console.WriteLine();
        }

    }

}