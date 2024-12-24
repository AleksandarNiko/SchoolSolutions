
using _04.Figures;

int n=int.Parse(Console.ReadLine());
List<ColoredFigure> figures = new List<ColoredFigure>();

for (int i = 0; i < n; i++)
{
    string[] lineToken = Console.ReadLine().Split();
    string figure = lineToken[0].ToLower();

    if (figure == "triangle")
    {
        string color = lineToken[1];
        double size=double.Parse(lineToken[2]);
        figures.Add(new Triangle(color, size));
    }
    else if (figure == "square")
    {
        string color = lineToken[1];
        double size = double.Parse(lineToken[2]);
        figures.Add(new Square(color, size));
    }
    else if (figure == "circle")
    {
        string color = lineToken[1];
        double radius = double.Parse(lineToken[2]);
        figures.Add(new Circle(color, radius));
    }
    else
    {
        Console.WriteLine("Invalid figure!");
    }
}
foreach (var fig in figures)
{
    Console.WriteLine($"{fig.GetType().Name}:");
    Console.WriteLine($"Color: {fig.Color}");
    Console.WriteLine($"Size: {fig.Size}");
    Console.WriteLine($"Area: {fig.GetArea():f2}");
}