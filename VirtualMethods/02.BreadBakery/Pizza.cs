using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BreadBakery
{
    public class Pizza : Loaf
    {
        const decimal ham = 0.90M;
        const decimal cheese = 0.70M;
        const decimal corn = 0.40M;
        const decimal mushrooms = 0.95M;

        public Pizza(BreadType type, double weight, decimal price) 
            : base(type, weight, price)
        {
        }

        public override decimal Price { get => base.Price; set => base.Price = value+ham+cheese+corn+mushrooms; }

        public override string GetContent()
        {
            return base.GetContent() + "ham, cheese, corn, mushrooms";
        }

    }
}