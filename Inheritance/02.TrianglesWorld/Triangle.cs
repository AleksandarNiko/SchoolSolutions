using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TrianglesWorld
{
    public class Triangle
    {
        private string name;
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

        public string Name { get => name; 
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null!");
                }
                name = value;
            }
        }

        public double SideA { get => sideA; set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Sides cannot be negative numbers");
                }
                sideA = value;
            }
        }
        public double SideB { get => sideB; set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Sides cannot be negative numbers");
                }
                sideB = value;
            }
        }
        public double SideC { get => sideC; set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Sides cannot be negative numbers");
                }
                sideC = value;
            }
        }

        public double Perimeter()
        {
            return SideA+SideB+SideC;
        }
    }
}
