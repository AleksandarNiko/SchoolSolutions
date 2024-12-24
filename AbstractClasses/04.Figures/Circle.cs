using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Figures
{
    public class Circle : ColoredFigure
    {
        public Circle(string color, double size) 
            : base(color, size)
        {

        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(this.Size, 2);
        }

        public override string GetName()
        {
            return "Circle";
        }
    }
}
