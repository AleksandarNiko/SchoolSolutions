using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Furnitures
{
    public class Chair : Furniture
    {
        private string color;
        private string size;
        public Chair(FurnitureType name, decimal priceToMake, string color, string size) 
            : base(name, priceToMake)
        {
            Color = color;
            Size = size;
        }

        public string Color { get => color; set => color = value; }
        public string Size { get => size; set => size = value; }

        public override decimal PriceClient()
        {
            decimal profitMargin = 0.25m;
            decimal pricePerClient = this.PriceToMake + (this.PriceToMake * profitMargin);
            return pricePerClient;
        }

        public override decimal PriceDistributor()
        {
            decimal profitMargin = 0.15m;
            decimal distributorPrice = this.PriceToMake + (this.PriceToMake * profitMargin);
            return distributorPrice;
        }

        public override string ToString()
        {
            return $"Name: {Name}" +
                $"\n Color: {Color}";
        }
    }
}
