using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintX1AndX2();
        }

        static void PrintX1AndX2()
        {
            Console.WriteLine("Write b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Write a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Write c:");
            double c = double.Parse(Console.ReadLine());

            double D = b * b - 4 * a * c;

            double x = 0;
            double x2 = 0;
            if (D < 0)
            {
                Console.WriteLine("Няма корени.");
            }
            else if (D == 0)
            {
                x = -b / 2 * a;
                Console.WriteLine($"x={x}");
            }
            else if (D > 0)
            {
                x = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"x1={x}");
                Console.WriteLine($"x2={x2}");
            }
    }
    }
}
