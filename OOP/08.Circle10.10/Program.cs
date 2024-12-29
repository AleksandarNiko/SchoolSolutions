
using _08.Circle10._10;

Console.WriteLine("Enter circles count:");

int n=int.Parse (Console.ReadLine()!);
Circle[] circles = new Circle[n];

for (int i = 0; i < n; i++)
{
    string name=Console.ReadLine()!;
    double radius=double.Parse (Console.ReadLine()!);
    circles[i] = new Circle(name, radius);
}

foreach (Circle circle in circles)
{
    Console.WriteLine(circle.ToString());
}
Console.WriteLine();
Console.WriteLine("Smallest circle radius name:");
SmallestRadius(circles);


static void SmallestRadius(Circle[] circles)
{
    var smallestCircle = circles.Min(c => c.Radius);

    Circle newCircle = null;
    foreach (var circle in circles)
    {
        if (circle.Radius == smallestCircle)
        {
            newCircle = circle;
        }
    }
    Console.WriteLine(newCircle.Name);
}


