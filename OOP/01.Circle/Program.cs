
using _01.Circle;

Circle circle = new Circle();

string name=Console.ReadLine()!;

double radius=double.Parse(Console.ReadLine()!);

circle.InsertName(name);
circle.InsertRadius(radius);

Console.WriteLine($"C = {circle.Circumference(radius)}");
Console.WriteLine($"S = {circle.Area(radius)}");