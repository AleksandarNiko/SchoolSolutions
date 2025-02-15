namespace GetDigits
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            ReturnDigits(number);
        }

        private static void ReturnDigits(int number)
        {
            string numberAsString = number.ToString();
            for (int i = 0; i < numberAsString.Length; i++)
            {
                Console.Write(numberAsString[i] + " ");
            }
            Console.WriteLine();
        }
    }
}