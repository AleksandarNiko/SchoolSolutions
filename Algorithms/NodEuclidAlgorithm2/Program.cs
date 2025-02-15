namespace NodEuclidAlgorithm2
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

            Console.WriteLine("The greatest common divisor is: " + a);
        }

        private static void Nod(ref int a, ref int b)
        {
            while (b != 0)
            {
                int maxB = b;

                b = a % b;

                a = maxB;
            }
        }
    }
}
