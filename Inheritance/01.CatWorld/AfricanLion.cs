using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CatWorld
{
    public class AfricanLion : Lion
    {
        public AfricanLion(bool male, int weight) : base(male, weight)
        {

        }

        public string LionMale()
        {
            if (this.Male == false) 
            {
                return "Female";
            }
            return "Male";
        }

        public override string ToString()
        {
            return $"AfricanLion, male {LionMale()}, weight: {Weight}.";
        }
    }
}
