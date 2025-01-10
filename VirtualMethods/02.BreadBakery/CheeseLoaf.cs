using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BreadBakery
{
    public class CheeseLoaf : Loaf
    {
        const decimal cheese = 0.80M;
        const decimal eggs = 0.50M;
        public CheeseLoaf(BreadType type, double weight, decimal price) 
            : base(type, weight, price)
        {

        }

        public override decimal Price { get => base.Price; set => base.Price = value+cheese+eggs; }

        public override string GetContent()
        {
            return base.GetContent() + "cheese, eggs";
        }
    }
}
