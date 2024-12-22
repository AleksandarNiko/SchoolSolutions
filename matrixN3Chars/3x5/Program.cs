using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3x5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matr = new int[4, 5];
            Random r = new Random();

            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = r.Next(100, 10000);
                    Console.Write(matr[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int sum = 0;
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    while (matr[i, j] > 0)
                    {
                        sum += matr[i, j] % 10;
                        matr[i, j] = matr[i, j] / 10;
                    }
                    Console.Write(sum+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
