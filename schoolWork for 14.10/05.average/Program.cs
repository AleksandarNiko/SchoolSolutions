using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05.average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n=double.Parse(Console.ReadLine());
            double average = 0;
            double sum = 0;
            int count = 0;
            while(n<=100 && n%7==0)
            {            
                sum += n;
                count++;
                average =sum/count;              
            }
            Console.WriteLine(average);
        }

    }
}
