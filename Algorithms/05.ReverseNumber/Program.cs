namespace ReverseNumber
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int reverse = ReverseWithNums(ref number);
            //int reverseWithStr = ReverseWithString(number);

            Console.WriteLine("The reverse number is: " + reverse);
        }

        static int ReverseWithNums(ref int number)
        {
            int reverse = 0;
            while (number > 0)
            {
                int digit = number % 10;
                reverse = reverse * 10 + digit;
                number /= 10;
            }

            return reverse;
        }

        static int ReverseWithString(int number)
        {
            string numberStr = number.ToString();
            string reverseStr = string.Empty;
            for (int i = numberStr.Length - 1; i >= 0; i--)
            {
                reverseStr += numberStr[i];
            }

            return int.Parse(reverseStr);
        }
    }
}
