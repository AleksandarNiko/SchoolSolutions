
double x = double.Parse(Console.ReadLine());

double y = double.Parse(Console.ReadLine());

FindQuadrant (x, y);

BisectorOfTheQuadrangle(x, y);

DistanceFromPointToOriginOfCoordinateSystem(x, y);

static void FindQuadrant(double x, double y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Точката лежи в Квадрант 1.");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Точката лежи в Квадрант 2.");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Точката лежи в Квадрант 3.");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Точката лежи в Квадрант 4.");
    }
    else
    {
        Console.WriteLine("Точката лежи върху оста.");
    }
}

static void BisectorOfTheQuadrangle(double x, double y)
{
    if (x == y)
    {
        Console.WriteLine("Точката лежи върху ъглополовящата на квадрантите.");
    }
    else
    {
        Console.WriteLine("Точката не лежи върху ъглополовящата на квадрантите.");
    }
}

static void DistanceFromPointToOriginOfCoordinateSystem(double x, double y)
{
    double distance = Math.Sqrt(x * x + y * y);
    Console.WriteLine($"Разстоянието от точката до началото е {distance}.");
}