int num=int.Parse(Console.ReadLine()!);
int sum = 0;
int evensCount = 0;

while (num != 0)
{
    num = int.Parse(Console.ReadLine()!);
    sum += num;
    if (num%2==0) evensCount++;
}

Console.WriteLine($"Sum of numbers: {sum}");
Console.WriteLine($"Even numbers count: {evensCount}");

