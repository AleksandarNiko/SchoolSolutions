
int m=int.Parse(Console.ReadLine());
int n=int.Parse(Console.ReadLine());

int nod = Nod2(m, n);

Console.WriteLine(nod);

static int Nod(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        if (m > n)
        { 
            return Nod(m-n, n);
        }
        else
        {
            return Nod(m, n-m);
        }
    }
}

static int Nod2(int m, int n)
{
    if (m % n == 0) 
    {
        return n;
    }
    else
    {
        return Nod2(n, m % n);
    }
}

