namespace GetDigits
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                int digit = number % 10;
                Console.Write(digit + " ");
                number /= 10;
            }
            Console.WriteLine();
        }
    }
}