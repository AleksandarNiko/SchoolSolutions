using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop
{
    public class Car
    {
        private string brand;
        private string model;
        private DateTime createdOn;

        public Car(string brand, string model, DateTime createdOn)
        {
            Brand = brand;
            Model = model;
            CreatedOn = createdOn;
        }

        public string Brand { get => brand; set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value cannot be null");
                }
                brand = value;
            } 
        }

        public string Model { get => model; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value cannot be null");
                }
                model = value;
            }
        }

        public DateTime CreatedOn { get => createdOn; set => createdOn = value; }
    }
}
