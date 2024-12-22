
for (int i = 100; i < 1000; i++)
{
    int sum=(i/100)+((i/10)%10)+(i%10);
    if (sum % 3 == 0)
    {
        Console.WriteLine(i);
    }
}
