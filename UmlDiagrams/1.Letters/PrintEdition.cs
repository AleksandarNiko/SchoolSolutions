using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Letters
{
    public class PrintEdition
    {
        private string name;
        private double pages;

        public PrintEdition(string name, double pages)
        {
            this.name = name;
            this.pages = pages;
        }

        public override string ToString()
        {
            return $"{name} има {pages} страници.";
        }
    }
}
