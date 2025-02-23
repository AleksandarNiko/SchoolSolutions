Console.Write("Въведи число: ");
int num=int.Parse(Console.ReadLine());

bool isPrime=IsPrime(num);

if (!isPrime)
{
    Console.WriteLine("Числото не е просто!");
}
else
{
    Console.WriteLine("Числото е просто!");
}

static bool IsPrime(int number,int divisor = 2)
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
