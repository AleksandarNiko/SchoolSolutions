
//Определяне на едно число ПРОСТО ЛИ Е

using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (number < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine("The number is prime.");
            }
            else
            {
                Console.WriteLine("The number is not prime.");
            }
        }
    }
}
