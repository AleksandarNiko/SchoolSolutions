using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Furnitures
{
    public abstract class Furniture
    {
        public FurnitureType Name { get; set; }

        public  decimal PriceToMake { get; set; }

        public Furniture(FurnitureType name, decimal priceToMake)
        {
            Name = name;
            PriceToMake = priceToMake;
        }

        public abstract decimal PriceClient();

        public abstract decimal PriceDistributor();
    }
}

public enum FurnitureType
{
    Chair,
    Table
}
