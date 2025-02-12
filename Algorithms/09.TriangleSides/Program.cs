

//Алгоритъм за определяне дали три числа могат да бъдат страни на триъгълник

using System;

namespace TriangleSides
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first side: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second side: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter third side: ");
            double c = double.Parse(Console.ReadLine());

            if (a + b > c
                && a + c > b 
                && b + c > a)
            {
                Console.WriteLine("The sides can be sides of a triangle.");
            }
            else
            {
                Console.WriteLine("The sides cannot be sides of a triangle.");
            }
        }
    }
}