using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TrianglesWorld
{
    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(string name, double side)
             : base(name, side, side, side) 
        {

        }

        public double Area()
        {
            return (Math.Sqrt(3) * (this.SideA * this.SideA)) / 4; 
        }
    }
}
