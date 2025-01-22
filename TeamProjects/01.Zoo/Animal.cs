using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Zoo
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public abstract void MakeSound();

        public override string ToString()
        {
            return $"{this.GetType().Name} {this.Name} {this.Age}";
        }

    }
}
