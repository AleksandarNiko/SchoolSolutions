Random r = new Random();
byte number = (byte)r.Next(10, 100);
Console.WriteLine($"Число:{number}");

for (int i = 0; i < number; i++)
{
    if (i % 5 == 0)
    {
        Console.WriteLine(i);
    }
}
