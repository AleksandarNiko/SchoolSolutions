using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Figures
{
    public class Triangle : ColoredFigure
    {
        public Triangle(string color, double size) 
            : base(color, size)
        {
            
        }
        public override double GetArea()
        {
            return Math.Pow(this.Size, 2) * Math.Sqrt(3) / 4;
        }

        public override string GetName()
        {
            return "Triangle";
        }
    }
}
