using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Parallelograms
{
    public class ParallelogramB : Parallelogram
    {
        private double side;
        private double height;
        private double angle;

        public ParallelogramB(double sideA, double height, double angle)
        {
            this.side = sideA;
            this.height = height;
            this.angle = angle;
        }

        public override double Face()
        {
            return side * height;
        }

        public override double Perimeter()
        {
            return 2 * (side + height);
        }
    }
}
