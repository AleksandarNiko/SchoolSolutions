using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Zoo
{
    public class Fish : Animal, IDiet, IHabitat
    {
        public Fish(string name, int age)
            : base(name, age)
        {
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} {this.Name} {this.Age}";
        }

        public override void MakeSound()
        {
            Console.WriteLine("Fish sound");
        }

        public void Swim()
        {
            Console.WriteLine("I'm swimming");
        }

        public void GetDietType()
        {
            Console.WriteLine("Fish eat algae");
        }

        public void GetHabitatType()
        {
            Console.WriteLine("Fish live in water");
        }

    }
}
