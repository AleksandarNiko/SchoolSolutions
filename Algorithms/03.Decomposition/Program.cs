namespace Decomposition
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int i = 2;
            while (number > 1)
            {
                if (number % i == 0)
                {
                    Console.Write(i + " ");
                    number /= i;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine();
        }
    }
}
