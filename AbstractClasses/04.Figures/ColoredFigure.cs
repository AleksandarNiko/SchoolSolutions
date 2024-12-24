using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Figures
{
    public abstract class ColoredFigure
    {
        private string color;
        private double size;

        public string Color { get => color; set => color = value; }
        public double Size { get => size; set => size = value; }

        public ColoredFigure(string color, double size)
        {
            this.Color = color;
            this.Size = size;
        }

        public void Show()
        {
            Console.WriteLine("Color: {0}, Size: {1}", this.Color, this.Size);
        }

        public abstract string GetName();

        public abstract double GetArea();
    }
}
