using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RestaurantVisual
{
    public class MenuItem
    {

        public MenuItem(string nameFood, decimal price)
        {
            NameFood = nameFood;
            Price = price;
        }

        public MenuItem() { }
        public  string NameFood { get; set; }

        public  decimal Price { get; set; }

        public override string ToString()
        {
            return $"{NameFood} - {Price}lv.";
        }
    }
}