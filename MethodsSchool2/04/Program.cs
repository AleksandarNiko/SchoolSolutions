using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintBiggers();
        }
         static void PrintBiggers()
        {
            Console.WriteLine("Write number:");
            int num = int.Parse(Console.ReadLine());
            List<int> bigs = new List<int>();
            for (int i = num; i < int.MaxValue; i++)
            {
                if (i > num)
                {
                    bigs.Add(i);

                    if (bigs.Count == 5)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", bigs));
        }
    }
    }

