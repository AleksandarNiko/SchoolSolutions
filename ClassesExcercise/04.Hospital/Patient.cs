using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hospital
{
    public class Patient
    {
        private string name;
        private string address;
        private byte age;
        private string diagnose;

        public string Name { get => name; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                name = value;
            }
        }

        public string Address { get => address; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                address = value;
            }
        }

        public byte Age { get => age; set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid number!");
                }
                age = value;
            }
        }

        public string Diagnose { get => diagnose; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                diagnose = value;
            }
        }

        private string[] dangers = { "хепатит", "COVID19", "шарка " };

        public Patient(string name, string address, byte age, string diagnose)
        {
            Name = name;
            Address = address;
            Age = age;
            Diagnose = diagnose;
        }

        public string IsDanger()
        {
            if (dangers.Contains(Diagnose))
            {
                return "заразен";
            }

            return "не е заразен";
        }

        public override string ToString()
        {
            return $"Name: {Name}; Address: {Address};  Age: {Age} Diagnose: {Diagnose}]";
        }
    }
}
