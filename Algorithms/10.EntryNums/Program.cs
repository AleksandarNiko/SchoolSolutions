
Console.Write("Enter number: ");
int num=int.Parse(Console.ReadLine());
int sum = 0;
int count = 0;
int primesCount = 0;

while (num!=0)
{
    Console.Write("Enter number: ");
    num =int.Parse(Console.ReadLine());

    sum += num;
    count++;

    if (IsPrime(num))
    {
        primesCount++;
    }
}

double average = (double)sum / count;

Console.WriteLine($"Average: {average}");
Console.WriteLine($"Prime nums count: {primesCount}");


static bool IsPrime(int number)
{
    bool isPrime = true;
    if (number < 2)
    {
        isPrime = false;
    }
    else
    {
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
    }

    return isPrime;
}