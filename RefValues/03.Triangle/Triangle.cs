using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Triangle
{
    public class Triangle
    {
        private string name = null!;
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(string name, double sideA, double sideB, double sideC)
        {
            Name = name;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public string Name { get => name; set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }
                name = value;
            } 
        }
        public double SideA { get => sideA; set 
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                sideA = value;
            }
        }
        public double SideB { get => sideB; set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                sideB = value;
            }
        }

        public double SideC { get => sideC; set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                sideC = value;
            }
        }

        public double Perimeter()
        {
            return SideA+SideB+SideC;
        }

        public double Area()
        {
            var area = Math.Sqrt((4 * Math.Pow(SideA,2) * Math.Pow(SideB,2)) - 
                Math.Pow((Math.Pow(SideA, 2) + Math.Pow(SideB, 2) - Math.Pow(SideC, 2)), 2));

            return Math.Round(area,4);
        }

        public double HeightOfA()
        {
            return Math.Round(Area() / SideA,3);
        }

    }
}
