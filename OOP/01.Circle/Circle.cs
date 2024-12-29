using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Circle
{
    public class Circle
    {
        private string name;
        private double radius;

        public void InsertName(string name)
        {
            this.name = name;
        }

        public void InsertRadius(double radius)
        {
            this.radius = radius;
        }

        public double Circumference(double radius)
        {
            return Math.Round(2 * Math.PI * radius, 2);
        }

        public double Area(double radius)
        {
            return Math.Round(Math.PI*Math.Pow(radius, 2), 2);
        }
    }
}
