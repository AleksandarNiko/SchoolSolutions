using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CatWorld
{
    public class Lion : Felidae
    {
        private int weight;

        public int Weight { get => weight; set => weight = value; }

        public Lion(bool male,int weight)
            :base(male)
        {

            Weight = weight;
        }
    }
}
