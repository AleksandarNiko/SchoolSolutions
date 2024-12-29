using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ProductWithValidation
{
    public class Product
    {
        private string name;
        private double price;

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get => name; private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Null or empty name!");
                }
                this.name = value;
            }
        }

        public double Price { get => price; private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid price!");
                }
                    price = value;
            }
        }



        public override string ToString()
        {
            return $"{Name} - {Price}lv";
        }
    }
}
