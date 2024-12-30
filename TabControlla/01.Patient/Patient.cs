using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Patient
{
    public class Patient
    {
        private string name;
        private byte age;
        private string diagnose;
        private int daysInHospital;

        public Patient(string name, byte age, string diagnose,int daysInHospital)
        {
            Name = name;
            Age = age;
            Diagnose = diagnose;
            DaysInHospital = daysInHospital;
        }

        public string Name { get => name; set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"Invalid name: {nameof(value)}");
                }
                name = value;
            }
        }

        public byte Age { get => age; set 
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Invalid age: {nameof(value)}");
                }
                age = value;
            }
        }

        public string Diagnose { get => diagnose; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"Invalid diagnose: {nameof(value)}");
                }
                diagnose = value;
            }
        }

        public int DaysInHospital { get => daysInHospital; set
            {
                if (value < 3)
                {
                    throw new ArgumentException($"Invalid days: {nameof(value)}");
                }
                daysInHospital = value;
            }
        }

        public decimal PriceToPay(decimal pricePerDay)
        {
            return pricePerDay * DaysInHospital;
        }

        public override string ToString()
        {
            return $"Name: {Name}; Age: {Age}; Diagnose: {Diagnose}; Days in hospital: {DaysInHospital}.";
        }
    }
}
