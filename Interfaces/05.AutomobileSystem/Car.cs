using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.AutomobileSystem.Interfaces;

namespace _05.AutomobileSystem
{
    public class Car : IRefuelable, IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("Колата е в движение.");
        }

        public void Refuel()
        {
            Console.WriteLine("Колата се зарежда с гориво.");
        }
    }
}
