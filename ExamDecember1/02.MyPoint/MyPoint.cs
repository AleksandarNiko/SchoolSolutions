using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MyPoint
{
    public static class MyPoint
    {
        public static string Kvadrant(double x, double y)
        {
            string quadrant = "";

            if(x > 0 && y > 0)
            {
                quadrant = "Първи квадрант";
            }
            else if(x<0 && y>0)
            {
                quadrant = "Втори квадрант";
            }
            else if(x<0 && y < 0)
            {
                quadrant = "Трети квадрант";
            }
            else
            {
                quadrant = "Четвърти квадрант";
            }

            return quadrant;
        }

        public static bool Bisector(double x, double y) 
        {
            return Math.Abs(x)==Math.Abs(y);
        }

        public static double Razstoqnie(double x, double y) 
        {
            double result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return Math.Round(result,2);
        }

        public static double DistancePoint(double x1, double y1, double x2, double y2) 
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return Math.Round(distance,2);
        }

        public static string IsParallel(double x1, double y1, double x2, double y2) 
        {
            return (x1 == x2 || y1 == y2) ? "да" : "не";
        }
    }
}
