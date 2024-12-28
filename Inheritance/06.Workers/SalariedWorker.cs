using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Workers
{
    public class SalariedWorker : Worker
    {
        public SalariedWorker(string name, decimal payPerHour, string workType) 
            : base(name, payPerHour, workType)
        {
        }

        public decimal Salary()
        {
            return 40*PayPerHour;
        }
    }
}
