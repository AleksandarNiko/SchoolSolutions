
int n =int.Parse(Console.ReadLine()!);
double sum = 0;
double syb;
if (n < 2)
{
    Console.WriteLine("Невалидно число!");
}
else
{
	for (int i = 1; i <= n*2; i++)
	{
		 syb = 1.0 / i;
		sum += syb;
	}
}

