using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Zoo
{
    public class Bird : Animal,IDiet, IHabitat
    {
        public Bird(string name, int age)
            : base(name, age)
        {
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} {this.Name} {this.Age}";
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bird sound");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }

        public void GetDietType()
        {
            Console.WriteLine("Birds eat seeds");
        }

        public void GetHabitatType()
        {
            Console.WriteLine("Birds live in nests");
        }


    }
}
