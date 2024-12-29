using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Product
{
    public class Product
    {
        public Product(string name, string group, string unitOfMeasurement, decimal arrivePrice)
        {
            Name = name;
            Group = group;
            UnitOfMeasurement = unitOfMeasurement;
            ArrivePrice = arrivePrice;
        }

        public string Name { get; set; }

        public  string Group { get; set; }

        public  string UnitOfMeasurement { get; set; }

        public  decimal ArrivePrice { get; set; }

        public decimal PriceWithDDS()
        {
            return ArrivePrice -= ArrivePrice * 0.25m;
        }

        public override string ToString()
        {
            return $"{Name} {Group} {UnitOfMeasurement} {ArrivePrice}";
        }
    }
}
