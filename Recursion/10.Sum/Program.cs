
double x = double.Parse(Console.ReadLine());
double n = double.Parse(Console.ReadLine());
double result=RecursiveSum(x, n);
Console.WriteLine(result);


static double RecursiveSum(double x,double n)
{
    if (n == 0)
    {
        return 1;
    }
    else
    {
        return Math.Pow(x, n) + RecursiveSum(x, n - 1);
    }
}
