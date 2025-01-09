using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while (b != 0)
            {
                int maxB = b;
                b = a % b;
                a = maxB;
            }
            Console.WriteLine(a);
        }
    }
}
