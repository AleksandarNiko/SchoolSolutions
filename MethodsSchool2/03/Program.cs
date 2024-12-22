using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write type of figure:");
            string input = Console.ReadLine();
            if (input == "square")
            {
                Square();
            }
            else if (input == "circle")
            {
                Circle();
            }
            else if (input == "trapezoid")
            {
                Trapezoid();
            }
        }
        static void Square()
        {
            Console.WriteLine("Write a:");
            double a = double.Parse(Console.ReadLine());
            double result = a * a;
            Console.WriteLine($"S={result}");
        }
        static void Circle()
        {
            Console.WriteLine("Write r");
            double r = double.Parse(Console.ReadLine());
            double result = Math.PI * (r * r);
            Console.WriteLine($"S={result}");
        }
        static void Trapezoid()
        {
            Console.WriteLine("Write a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Write b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Write h");
            double h = double.Parse(Console.ReadLine());
            double result = ((a + b) * h) / 2;
            Console.WriteLine($"S={result}");
        }
    }
 }
