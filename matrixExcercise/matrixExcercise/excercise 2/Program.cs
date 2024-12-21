using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[,] matrix = new int[5, 5];
            int mult = 1;
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
            //multiplication of cols
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                mult = 1;

                for (int j = 0; j < matrix.GetLength(0); j++)
                {

                    mult *= matrix[j,i];
                }
                 Console.WriteLine($"Multiplication of col {i}: {mult}");               
            }
            //min mult of cols
            int min = int.MaxValue;
            int[] mults = new int[5];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                mult = 1;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    mult *= matrix[j, i];
                    mults[i] = mult;
                }
                if (mults[i] < min)
                {
                  min = mult;
                }                
            }
            Console.WriteLine($"Min multiplication: {min}");
        }
    }
}
