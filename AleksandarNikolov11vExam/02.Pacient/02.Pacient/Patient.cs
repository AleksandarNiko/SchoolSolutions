using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pacient
{
    public class Patient
    {
        private string name;
        private byte age;
        private string diagnose;

        public Patient(string name, byte age, string diagnose)
        {
            Name = name;
            Age = age;
            Diagnose = diagnose;
        }

        public string Name { get => name; set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid name!");
                }
                name = value;
            } 
        }

        public byte Age { get => age; set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid age!");
                }
                age = value;
            } 
        }

        public string Diagnose { get => diagnose; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid diagnose!");
                }
                diagnose = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}; Age: {Age}; Diagnose: {Diagnose}".ToString();
        }
    }
}
