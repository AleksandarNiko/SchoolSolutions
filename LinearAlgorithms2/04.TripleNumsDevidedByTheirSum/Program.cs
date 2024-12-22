int count = 0;

for (int i = 100; i < 1000; i++)
{
    int sum = (i / 100) + ((i / 10) % 10) + (i % 10);
    if (i % sum == 0)
    {
        Console.WriteLine(i);
        count++;
    }
}

Console.WriteLine($"Numbers count: {count}");
