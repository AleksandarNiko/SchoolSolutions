using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_01
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDigits();
        }

        private static void PrintDigits()
        {
            int a = 10;
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
