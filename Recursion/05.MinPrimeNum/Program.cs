
Console.Write("Въведи число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Отговор: {FindNextPrime(num)}");

static int FindNextPrime(int n)
{
    n++;

    if (IsPrime(n) == true)
    {
        return n;
    }
    else
    {
        return FindNextPrime(n);
    }
}

static bool IsPrime(int number, int divisor = 2)
{
    if (number < 2)
    {
        return false;
    }
    if (divisor > Math.Sqrt(number))
    {
        return true;
    }
    if (number % divisor == 0)
    {
        return false;
    }

    return IsPrime(number, divisor + 1);
}
