using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Write second number:");
            int num2 = int.Parse(Console.ReadLine());
            Nod(num1,num2);
        }

         static void Nod( int num1,  int num2)
        {
            while (num2 != 0)
            {
                int maxB = num2;
                num2 = num1 % num2;
                num1 = maxB;
            }
            Console.WriteLine(num1);
        }
    }
}
