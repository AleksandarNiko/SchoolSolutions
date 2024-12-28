using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TrianglesWorld
{
    public class ScaleneTriangle : Triangle
    {
        private double heightOfSideA;
        public ScaleneTriangle(string name, double sideA, double sideB, double sideC,double heightOfSideA) 
            : base(name, sideA, sideB, sideC)
        {
            HeightOfSideA = heightOfSideA;
        }

        public double HeightOfSideA { get => heightOfSideA; set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be negative number!");
                }
                heightOfSideA = value;
            } 
        }

        public double Area()
        {
            return (HeightOfSideA * this.SideA) / 2;
        }
    }
}
