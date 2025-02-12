namespace TheDecisionOfEratosthenes
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            bool[] isPrime = new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
                isPrime[i] = true;
            }
            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i])
                {
                    Console.Write(i + " ");
                    for (int j = i * i; j <= n; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}


