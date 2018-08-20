using System;
using System.Collections.Generic;
using System.Linq;

namespace DistanceBetweenPoints
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();


            double distance = CalcDistance(p1, p2);

            Console.WriteLine($"Distance: {distance:f3}");

        }
    }
    static Point ReadPoint()
    {
        int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Point point = new Point();
        point.X = pointInfo[0];
        point.Y = pointInfo[1];

        return point;
    }




    static double CalcDistance(double p1, double p2)
    {
        
    }


}
