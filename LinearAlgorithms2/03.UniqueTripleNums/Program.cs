
int count = 0;

for (int i = 100; i < 1000; i++)
{
    int hundreds = i / 100;
    int tens = (i / 10) % 10;
    int units = i % 10;

    if (hundreds != tens && hundreds != units && tens != units)
    {
        Console.WriteLine(i);
        count++;
    }
}

Console.WriteLine($"Unique triple numbers count: {count}");
