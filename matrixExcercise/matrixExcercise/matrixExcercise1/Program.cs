using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixExcercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[,] matrix = new int[10,10];
            int sum = 0;

            //input elements in matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(1, 6);
                }
            }

            //print the matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            //sum of elements in matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                Console.WriteLine($"Sum of row {i+1}: {sum}");
            }
            // max sum of rows
            int max = int.MinValue;
            int[] sums = new int[10];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                    sums[i] = sum;
                }
                if (max < sums[i])
                {
                    max = sum;
                }
            }
                Console.WriteLine($"Max number= {max}");
            
        }
    }
}
