using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix4x4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 4];
            Random random = new Random();

            //input elements in matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(10, 99);
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

            //print the principal diagonal
            Console.Write("Main diagonal:");
            int[] diagonalElements = new int[4];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        diagonalElements[i] = matrix[i, j];
                        Console.Write(matrix[i, j] + " ");
                       
                    }
                }
            }
            //print sorted principal diagonal
            for (int k = 0; k < diagonalElements.Length; k++)
            {
                int min = diagonalElements[k];
                int indexMin = k;
                for (int a = k + 1; a < diagonalElements.Length; a++)
                {
                    if (min > diagonalElements[a])
                    {
                        min = diagonalElements[a];
                        indexMin = a;
                    }
                }
                    int temp= diagonalElements[k];
                diagonalElements[k] = diagonalElements[indexMin];
                diagonalElements[indexMin] = temp;
            }             
            
            Console.WriteLine();
            Console.WriteLine($"Sorted principal diagonal->{string.Join(" ",diagonalElements)}");

            //изведете елементите на вторичния диагонал,
            //определете най-малкия елемент измежду тях и го изведете. 
            int minimum = int.MaxValue;
            Console.Write("Secondary Diagonal: ");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i + j) == (matrix.GetLength(1) - 1))
                    {
                        Console.Write(matrix[i, j] + ", ");
                        if (minimum > matrix[i, j])
                        {
                            minimum = matrix[i, j];
                        }
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"Min num of secondary diag ->{minimum}");



            //намерете сумата на елементите под главния диагонал;
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i > j)
                    {
                        sum += matrix[i, j];                       
                    }
                }
            }
            Console.WriteLine($"Sum of elements below principal diagonal->{sum}");


            //намерете произведението на елементите над главния диагонал; 
            int multSum = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        multSum *= matrix[i,j];
                    }
                }
            }
            Console.WriteLine($"Multiplied sum of elements up principal diagonal->{multSum}");


            //Измежду всички най-големи елементи по редове намерете най-малкия. 
            int minElement = int.MaxValue;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    if (matrix[i, j] < minElement)
                    {
                        minElement = matrix[i,j];
                    }
                }
            }
            Console.WriteLine($"Min element->{minElement}");
        }
    }
}

