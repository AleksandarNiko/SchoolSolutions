using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop
{
    public class ManufacturerCompany
    {
        private string name;
        private string country;

        public ManufacturerCompany(string name, string country)
        {
            Name = name;
            Country = country;
        }

        public string Name { get => name; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value cannot be null");
                }
                name = value;
            }
        }

        public string Country { get => country; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value cannot be null");
                }
                country  = value;
            }
        }
    }
}
