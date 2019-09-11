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
using ConvexHull;

namespace ConvexHull
{

    public class Demo
    {

        static List<Point> listPoints = null;

        static void GrahamScanDemo()
        {
            GrahamScan gs = new GrahamScan();

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var result = gs.convexHull(listPoints);
            stopwatch.Stop();
            float elapsed_time = stopwatch.ElapsedMilliseconds;

            foreach (Point value in result)
            {
                Console.Write("(" + value.X + "," + value.Y + ") ");
            }
            Console.WriteLine();
            Console.WriteLine("Elapsed time: {0} milliseconds", elapsed_time);
        }

        static void JarvisMarchDemo()
        {
            JarvisMarch jm = new JarvisMarch();

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var result = jm.convexHull(listPoints);
            stopwatch.Stop();
            float elapsed_time = stopwatch.ElapsedMilliseconds;

            foreach (Point value in result)
            {
                Console.Write("(" + value.X + "," + value.Y + ") ");
            }
            Console.WriteLine();
            Console.WriteLine("Elapsed time: {0} milliseconds", elapsed_time);
            Console.ReadLine();
        }

        public static void Main()
        {
            listPoints = new List<Point>();

            listPoints.Add(new Point(9, 1));
            listPoints.Add(new Point(4, 3));
            listPoints.Add(new Point(4, 5));
            listPoints.Add(new Point(3, 2));
            listPoints.Add(new Point(14, 2));
            listPoints.Add(new Point(4, 12));
            listPoints.Add(new Point(4, 10));
            listPoints.Add(new Point(5, 6));
            listPoints.Add(new Point(10, 2));
            listPoints.Add(new Point(1, 2));
            listPoints.Add(new Point(1, 10));
            listPoints.Add(new Point(5, 2));
            listPoints.Add(new Point(11, 2));
            listPoints.Add(new Point(4, 11));
            listPoints.Add(new Point(12, 4));
            listPoints.Add(new Point(3, 1));
            listPoints.Add(new Point(2, 6));
            listPoints.Add(new Point(2, 4));
            listPoints.Add(new Point(7, 8));
            listPoints.Add(new Point(5, 5));

            Console.WriteLine("Graham Scan Results:");
            GrahamScanDemo();

            Console.WriteLine("\n\n==============================================\n\n");

            Console.WriteLine("Jarvis March Results:");
            JarvisMarchDemo();

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();

        }

    }

}
