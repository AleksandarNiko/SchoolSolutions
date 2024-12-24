using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shop
{
    public class Product
    {
        private string name;
        private string code;
        private decimal price;
        private double quantity;

        public Product(string name, string code, decimal price, double quantity)
        {
            this.Name = name;
            this.Code = code;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string Name { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }
        public decimal Price { get => price; set => price = value; }
        public double Quantity { get => quantity; set => quantity = value; }

        public override string ToString()
        {
            return $"Name: {Name}, Barcode: {Code}, Price: {Price}, Quantity: {Quantity}";
        }
    }
}