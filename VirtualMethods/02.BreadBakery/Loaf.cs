using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BreadBakery
{
    public class Loaf
    {
        public Loaf(BreadType type, double weight, decimal price)
        {
            Type = type;
            Weight = weight;
            Price = price;
        }

        public  BreadType Type { get; set; }

        public  double Weight { get; set; }

        public  virtual decimal  Price { get; set; }

        public virtual string GetContent()
        {
            return $"{Type.ToString()}, Warm water, Salt, Oil";
        }
    }
}

public enum BreadType
{
    Wheat,
    Typical,
    Whole_Grain,
    Gluten_Free
}