namespace NodEuclidAlgorithm1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            Nod(ref a, ref b);

            Console.WriteLine("The greatest common divisor is: " + b);
        }

        static void Nod(ref  int a, ref int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
        }
    }
}