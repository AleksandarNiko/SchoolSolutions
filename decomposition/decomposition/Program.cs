using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decomposition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int dec = 0;
            for (int i = 2; i < num; i++)
            {
                dec = num % i;
                if (dec == 0)
                {
                    num -= dec;
                    Console.WriteLine(i);
                }
            }
        }
    }
}
