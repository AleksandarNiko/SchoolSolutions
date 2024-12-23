using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sedlovaTocka
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 5]; 
            Random random = new Random();

            //print matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(10, 100);
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
            //min numbers in cols
            List<int> mins = new List<int>();
            Console.WriteLine("min numbers in cols:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int min = matrix[0, i];
                for (int j = 1; j < matrix.GetLength(0); j++)
                    if (matrix[j, i] < min)
                        min = matrix[j, i];
                mins.Add(min);
                
            }
            Console.WriteLine(string.Join(" ", mins));

            //max numbers in cols
            int[] maxes = new int[matrix.GetLength(1)];
            Console.WriteLine("max numbers in cols:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int max = int.MinValue;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
                maxes[i] = max;
            }
            Console.WriteLine(string.Join(" ", maxes));
        }
    }
}
