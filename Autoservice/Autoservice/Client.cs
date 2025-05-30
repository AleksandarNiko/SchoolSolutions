using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoservice
{
    public class Client
    {
        private string name;
        private string automobile;
        private string problem;

        public string Name
        {
            get => name; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("value");
                }
                name = value;
            }
        }
        public string Automobile{ get; set; }
        public string Problem
        {
            get => problem; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("value");
                }
                problem = value;
            }
        }

        public Client(string name, string automobile, string problem)
        {
            Name = name;
            Automobile = automobile;
            Problem = problem;
        }
        public override string ToString()
        {
            return $"{Name} с {Automobile} - проблем: {Problem}";
        }
    }
}
