namespace _08.Nok
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            int a1 = a;
            int b1 = b;

            Nod(ref a, ref b);

            int nod = a;
            int nok = a1 * b1 / nod;
            Console.WriteLine("LCM = " + nok);
        }

        static void Nod(ref int a, ref int b)
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
