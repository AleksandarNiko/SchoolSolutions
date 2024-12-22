using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDiscriminanta();
        }

        static void PrintDiscriminanta()
        {
            Console.WriteLine("Write b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Write a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Write c:");
            double c = double.Parse(Console.ReadLine());

            double result = b * b - 4 * a * c;
            Console.WriteLine($"D={result}");
        }
    }
    }

