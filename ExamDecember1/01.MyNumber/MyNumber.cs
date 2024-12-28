using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _01.MyNumber
{
    public static class MyNumber
    {
        public static bool ProstoLie(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static int Obratno(int number)
        {
            // First Variant
            //string textedNumber=number.ToString();
            //string reversedTexedNumber = "";

            //for (int i = textedNumber.Length - 1; i >= 0; i--)
            //{
            //    reversedTexedNumber += textedNumber[i];
            //}

            //return int.Parse(reversedTexedNumber);

            //Second Variant
            int reversed = 0;
            while (number != 0)
            {
                int digit = number % 10;
                reversed = reversed * 10 + digit;
                number /= 10;
            }
            return reversed;
        }

        public static List<int> ProstiDeliteli(int number) 
        {
            List<int> primeDivisors = new List<int>();

            //for (int i = 2; i <= number; i++)
            //{
            //    if (number % i == 0 && ProstoLie(i))
            //    {
            //        primeDivisors.Add(i);
            //    }
            //}

            int i = 2;
            while (number > 1)
            {
                while (number % i == 0)
                {
                    primeDivisors.Add(i);
                    number /= i;
                }
                i++;
            }
            return primeDivisors;
        }

        public static string IsEven(int number) 
        {
            return number % 2 == 0 ? "четно" : "нечетно";
        }

        public static string IsPolindrom(int number)
        {
            //First Variant
            //string strNumber = number.ToString();

            //char[] charsArray = strNumber.ToCharArray();
            //var reversedChars=new List<char>();

            //for (int i = charsArray.Length - 1; i >= 0; i--)
            //{
            //    reversedChars.Add(charsArray[i]);
            //}

            //string reversedNumber = "";

            //foreach (var c in reversedChars) 
            //{
            //    reversedNumber += c;
            //}

            //return (strNumber == reversedNumber && number > 10) ? "полиндром" : "не е полиндром";

            //Second Variant
            return (number == Obratno(number) && number > 10) ? "полиндром" : "не е полиндром";
        }
    }
}
