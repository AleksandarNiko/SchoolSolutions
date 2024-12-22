using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prqkaSelekciq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] eightArray = new int[8];
            for (int i = 0; i < eightArray.Length; i++)
            {
                eightArray[i] = int.Parse(Console.ReadLine());

            }
                for (int i = 0; 1 < eightArray.Length; i++)
                {
                    int min = eightArray[i];
                    int position = i;
                    for (int j = i + 1; j < eightArray.Length; j++)
                    {
                        if (min > eightArray[j])
                        {
                            min = eightArray[j];
                            position = j;
                        }
                    }
                    int x = eightArray[i];
                    eightArray[i] = eightArray[position];
                    eightArray[position] = x;
                }
                for (int i = 0; i < eightArray.Length; i++)
                {
                    Console.WriteLine(eightArray[i]);
                }
                Console.WriteLine();
            }
        }
    }

