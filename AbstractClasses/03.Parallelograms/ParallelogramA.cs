using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Parallelograms
{
    public class ParallelogramA : Parallelogram
    {
        private double sideA;
        private double sideB;
        private double angle;

        public ParallelogramA(double sideA, double sideB, double angle)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.angle = angle;
        }

        public override double Face()
        {
            return sideA * sideB * Math.Sin(angle * Math.PI / 180);
        }

        public override double Perimeter()
        {
            return 2 * (sideA + sideB);
        }
    }
}
