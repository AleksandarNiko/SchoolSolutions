
int n=int.Parse(Console.ReadLine());
int fac=Fact(n);

Console.WriteLine(fac);

static int Fact(int n)
{
    if(n == 0)
    {
        return 1;
    }
    else
    {
        return n*Fact(n-1);
    }
}
