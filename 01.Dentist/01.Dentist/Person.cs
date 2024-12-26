using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Dentist
{
    public class Person
    {
        private string name;
        private string dateOfBirth;

        public Person(string name, string dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public string Name { get => name; set 
            {
                if (string.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentNullException(value);
                }
                name = value;
            } }

        public string DateOfBirth { get => dateOfBirth; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(value);
                }
                dateOfBirth = value;
            }
        }
    }
}
