using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.City
{
    public class City
    {
        private string name;
        private int population;
        private int postCode;
        private bool isRegional;

        public City(string name, int population, int postCode, bool isRegional)
        {
            Name = name;
            Population = population;
            PostCode = postCode;
            IsRegional = isRegional;
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

        public int Population { get => population; set 
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Population cannot be negative number!");
                }
                population = value;
            }
        }

        public int PostCode { get => postCode; set 
            {
                if (value<1000 || value > 9999)
                {
                    throw new ArgumentOutOfRangeException("Invalid postcode!");
                }
                postCode = value;
            }
        }

        public bool IsRegional { get => isRegional; set => isRegional = value; }

        public override string ToString()
        {
            return $"City name: {Name}; Population: {Population}; Postcode: {PostCode}; IsRegional: {IsRegional}";
        }
    }
}
