using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Circle10._10
{
    public class Circle
    {
        private string name;
        private double radius;

        public Circle(string name, double radius)
        {
            Name = name;
            Radius = radius;
        }

        public string Name { get => name; set => name = value; }

        public double Radius { get => radius; set => radius = value; }

        public double Circumference()
        {
            return Math.Round(2 * Math.PI * Radius, 2);
        }

        public double Area()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }

        public double PovNaKulbo() 
        {
            return Math.Round(4 * Math.PI * Math.Pow(Radius, 2), 2);
        }

        public double VolumeNaKulbo()
        {
            return Math.Round((4 * Math.PI * Math.Pow(Radius, 3)) / 3, 2);
        }

        public override string ToString()
        {
            return $"Окръжност {Name}(0, {Radius}) има следните стойности за: \n" +
                $"P={Circumference()} \n" +
                $"S={Area()} \n" +
                $"Sp={PovNaKulbo()} \n" +
                $"V={VolumeNaKulbo()}"
                .ToString()
                .Trim();
        }
    }
}
