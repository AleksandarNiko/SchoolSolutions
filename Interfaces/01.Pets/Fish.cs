using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Pets
{
    public class Fish : IPet
    {
        private string name;

        public string Name { get => name; set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null!");
                }
                name = value;
            }
        }
        public void Act()
        {
            Console.WriteLine($"{Name} swims.");
        }

        public string Eat()
        {
            return "Fish eat pond scum.";
        }
    }
}
