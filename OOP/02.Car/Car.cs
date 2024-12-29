using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Car
{
    public class Car
    {
        public Car(string brand, string model, double engineVolume, int yearOfMade)
        {
            Brand = brand;
            Model = model;
            EngineVolume = engineVolume;
            YearOfMade = yearOfMade;
        }

        public  string Brand { get; set; }

        public  string Model { get; set; }

        public  double EngineVolume { get; set; }

        public  int YearOfMade { get; set; }

        public double AnnualTax()
        {
            double taxFromVolume = 0.2 * EngineVolume;
            double taxFromYear = 0;
            double tax = 0;

            if (YearOfMade > 2010)
            {
                taxFromYear = 50;
            }
            else if(YearOfMade>=2001 && YearOfMade <= 2010)
            {
                taxFromYear = 60;
            }
            else
            {
                taxFromYear = 70;
            }

            tax=taxFromVolume+taxFromYear;

            return Math.Round(tax,2);

        }

        public override string ToString()
        {
            return $"Car: {Brand}, Model: {Model}, Volume of engine: {EngineVolume}," +
                $" Year of Made: {YearOfMade} with annual tax: {this.AnnualTax()}";
        }

    }
}
