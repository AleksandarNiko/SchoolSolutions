using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Person
{
    public class Person
    {
        private string id;
        private string name;

        public Person(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public string Name { get => name; set 
            {
                if(string.IsNullOrEmpty(value)==true)
                {
                    throw new ArgumentException("Name cannot be null or length should be 10 chars!");
                }
                name = value;
            } 
        }

        public string Id { get => id; set
            {
                if (string.IsNullOrEmpty(value) == true || value.Length != 10)
                {
                    throw new ArgumentException("Id cannot be null or length should be 10 chars!");
                }
                id = value;
            }
        }
    }
}
