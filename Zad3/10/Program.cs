
Console.Write("Въведи стойността на m: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Въведи стойността на n: ");
int n = int.Parse(Console.ReadLine()!);

int width = m * n - n + 1;
int height = m;
for (int y = 0; y < height; y++)
{
    for (int x = 0; x < width; x++)
    {
        Console.Write(' ');
        if (y == 0 || y == height - 1)
        {
            Console.Write("*");
        }
        else if (x % (m - 1) == 0)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(' ');
        }
    }
    Console.WriteLine();
}