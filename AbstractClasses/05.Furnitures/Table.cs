using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Furnitures
{
    public class Table : Furniture
    {
        private string kind;
        public Table(FurnitureType name, decimal priceToMake,string kind) 
            : base(name, priceToMake)
        {
            Kind = kind;
        }

        public string Kind { get => kind; set => kind = value; }

        public override decimal PriceClient()
        {
            decimal profitMargin = 0.22m;
            decimal pricePerClient = PriceToMake + (PriceToMake * profitMargin);
            return pricePerClient;
        }

        public override decimal PriceDistributor()
        {
            decimal profitMargin = 0.12m;
            decimal distributorPrice = PriceToMake + (PriceToMake * profitMargin);
            return distributorPrice;
        }

        public override string ToString()
        {
            return $"Name: {Name}" +
                $"\n Kind: {Kind}";
        }
    }
}
