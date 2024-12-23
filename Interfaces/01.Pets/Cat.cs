using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _01.Pets
{
    public class Cat : IPet
    {
        private string name;
        public  string Name { get=>name; set
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
            Console.WriteLine($"{Name} likes to play with string.");
        }

        public string Eat()
        {
            return "Cats eat mice.";
        }
    }
}
