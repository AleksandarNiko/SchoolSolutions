using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4x5
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] matr = new char[4, 5];
            Random r = new Random();

            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = (char)r.Next(33, 256);
                    Console.Write(matr[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (char.IsUpper(matr[i, j]))
                    {
                        Console.Write(matr[i, j]);
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
        }
    }

