using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix4x5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[,] matrix = new string[4, 5];
            Random random = new Random();

            
            int randValue;
            string str = "";
            char letter;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    randValue = random.Next(0, 26);
                    letter = Convert.ToChar(randValue + 65);
                    str = str + letter;
                     Console.Write(str);
                }
                Console.WriteLine();
            }
        }
    }
}
