using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BreadBakery
{
    public class KashkavalLoaf : Loaf
    {
        const decimal cheese = 0.75M;
        const decimal butter = 0.60M;

        public KashkavalLoaf(BreadType type, double weight, decimal price) 
            : base(type, weight, price)
        {

        }

        public override decimal Price { get => base.Price; set => base.Price = value+cheese+butter; }

        public override string GetContent()
        {
            return base.GetContent() + "cheese, butter";
        }
    }
}
