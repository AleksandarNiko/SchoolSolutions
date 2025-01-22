using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Zoo
{
    public class Mammal : Animal, IDiet, IHabitat
    {
        public Mammal(string name, int age)
            : base(name, age)
        {
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} {this.Name} {this.Age}";
        }

        public override void MakeSound()
        {
            Console.WriteLine("Mammal sound");
        }

        public void Run()
        {
            Console.WriteLine("I'm running");
        }

        public void GetDietType()
        {
            Console.WriteLine("Mammals eat meat");
        }

        public void GetHabitatType()
        {
            Console.WriteLine("Mammals live in forests");
        }
    }
}
