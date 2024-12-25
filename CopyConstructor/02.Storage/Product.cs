using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Storage
{
    public class Product
    {
        private string name;
        private int quantity;

        public Product(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public string Name { get => name; private set => name = value; }

        public int Quantity { get => quantity;  set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid quantity!");
                }
                quantity = value;
            } 
        }

        public override string ToString()
        {
            return $"Name: {Name} -> Quantity: {Quantity}";
        }
    }
}
