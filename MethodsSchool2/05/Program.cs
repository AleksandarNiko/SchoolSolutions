using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintLowers();
            
        }

         static void PrintLowers()
        {
            Console.WriteLine("Write number:");
            int num = int.Parse(Console.ReadLine());
            List<int> lows = new List<int>();
            for (int i = num - 1; i >= 1; i--)
            {
                if (i % 5 == 0)
                {
                    lows.Add(i);
                    if(lows.Count == 5)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", lows));
        }
    }
    }

