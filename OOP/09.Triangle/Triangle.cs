using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Triangle
{
    public class Triangle
    {
        private double sideA;
        private double sideB;
        private double sideC;
        private string name;

        public Triangle(string name,double sideA, double sideB, double sideC)
        {
            Name = name;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public string Name { get => name; set => name = value; }
        public double SideA { get => sideA; set => sideA = value; }
        public double SideB { get => sideB; set => sideB = value; }
        public double SideC { get => sideC; set => sideC = value; }

        public string TriangleType()
        {
            if (SideA == SideB && SideA == SideC)
            {
                return "равностранен триъгълник";
            }
            else if (SideA == SideB || SideA==SideC || SideB==SideC)
            {
                return "равнобедрен";
            }
            return "разностранен";
        }

        public double Pеrimeter()
        {
            return SideA+SideB+SideC;
        }

        public double Area()
        {
            double p = Pеrimeter() / 2;
            return Math.Round(Math.Sqrt(p*(p-SideA)*(p-SideB)*(p-SideC)));
        }

        public double Height()
        {
            return Math.Round(Area() / (SideA / 2),2);
        }

        public double BigR()
        {
            return Math.Round((SideA*SideB*SideC / 4*Area()), 2);
        }

        public double SmallR() 
        {
            double p= Pеrimeter()/2;
            return Math.Round(Area()/p/2,2);
        }

        public override string ToString()
        {
            return $"Триъгълник {Name} е: {TriangleType()}"
                .ToString();
        }
    }
}
