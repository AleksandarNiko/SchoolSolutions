using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad7_AleksN
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();

            //print matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(100, 200);
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            //elements under princ diag
            Console.Write("elements under principal diag: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i > j)
                    {
                        Console.Write(matrix[i, j]+" ");
                    }
                }
            }
            Console.WriteLine();
            //max numbers in cols
            Console.WriteLine("max numbers in cols:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int max = matrix[0, i];
                for (int j = 1; j < matrix.GetLength(0); j++)
                    if (matrix[j, i] > max)
                        max = matrix[j, i];
                Console.WriteLine(max);
            }
        }
    }
}
