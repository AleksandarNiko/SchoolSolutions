using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1.Letters
{
    public class Newsletter : PrintEdition
    {
        private double issueNumber;
        private string periodicity; 

        public Newsletter(string name, double pages,double issueNumber,string periodicity) 
            : base(name, pages)
        {
            this.issueNumber = issueNumber;
            this.periodicity = periodicity;
        }
        public override string ToString()
        {
            return $"{base.ToString()} Номер на броя: {this.issueNumber}; Периодиночст:{this.periodicity}.";
        }
    }
}
