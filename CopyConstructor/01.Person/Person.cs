using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Person
{
    public class Person
    {
        private string name;
        private byte age;

        public Person(string name, byte age)
        {
            Name = name;
            Age = age;
        }

        public Person(Person person)
        {
            Name = person.Name;
            Age = person.Age;
        }

        public string Name { get => name; set => name = value; }
        public byte Age { get => age; set => age = value; }

    }
}
