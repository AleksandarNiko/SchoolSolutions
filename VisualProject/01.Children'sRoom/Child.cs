using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Children_sRoom
{
    public class Child
    {
        private string name;
        private int age;

        public Child(string name, int age)
        {
            Name = name;
            Age = age;
            Groups = new List<Group>();
        }

        public string Name { get => name; set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null!");
                }
                name = value;
            } 
        }

        public int Age { get => age; set 
            {
                if (value < 10) 
                {
                    throw new ArgumentOutOfRangeException("Age cannot be less than 10!");
                }
                age = value;
            } 
        }

        public  List<Group> Groups { get; set; }
    }
}
