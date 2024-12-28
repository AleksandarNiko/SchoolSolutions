using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Workers
{
    public class HourlyWorker : Worker
    {
        public  decimal HSalary { get; set; }
        public HourlyWorker(string name, decimal payPerHour, string workType) 
            : base(name, payPerHour, workType)
        {

        }


        public void Salary(byte hours)
        {
            if (hours <= 40) 
            {
                HSalary = hours * PayPerHour;
            }
            else if(hours>=41 && hours <= 60)
            {
                HSalary = hours * (PayPerHour*1.5M);
            }
            else 
            {
                HSalary = hours * (PayPerHour * 2);
            }
        }
    }
}
