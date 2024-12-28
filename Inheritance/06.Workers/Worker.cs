using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Workers
{
    public class Worker
    {
        private string name;
        private decimal payPerHour;
        private string workType;

        public Worker(string name, decimal payPerHour, string workType)
        {
            Name = name;
            PayPerHour = payPerHour;
            WorkType = workType;
        }

        public string Name { get => name; set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null!");
                }
                name = value;
            }
        }

        public decimal PayPerHour { get => payPerHour; set 
            {
                if (value < 20)
                {
                    throw new ArgumentException("Value cannot be under 20!");
                }
                payPerHour = value;
            }
        }

        public string WorkType { get => workType; set => workType = value; }
    }
}