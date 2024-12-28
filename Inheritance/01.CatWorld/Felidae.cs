using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CatWorld
{
    public class Felidae
    {
        private bool male = true;

        public  bool Male { get=>male; set=>male=value; }

        public Felidae(bool male)
        {
            Male = male;
        }

        public Felidae()
        {

        }
    }
}
