using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RectanglesWorld
{
    public class Rectangle
    {
        private double sideA;
        private double sideB;

        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }
        public double SideA { get => sideA; set 
            {
                if(value < 0)
                {
                    throw new ArgumentException("Sides cannot be negative numbers!");
                }
                sideA = value;
            }
        }
        public double SideB { get => sideB; set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Sides cannot be negative numbers!");
                }
                sideB = value;
            }
        }

        public double Area()
        {
            return SideA * SideB;
        }

        public double Perimeter()
        {
            return 2 * SideA + 2 * SideB;
        }
    }
}
