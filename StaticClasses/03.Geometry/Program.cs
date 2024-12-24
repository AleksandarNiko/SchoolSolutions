
using System.Reflection.Metadata;
using static _03.Geometry.Geometry;

Console.WriteLine("Figures: square,rectangle,square");
while (true) 
{
    Console.WriteLine("Enter figure:");
    string fig = Console.ReadLine().ToLower();
    if (fig == "square")
    {
        Console.WriteLine("Enter value for a:");
        Console.Write("a:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine($"Area: {SquareArea(a)}");
        Console.WriteLine($"Perimeter: {SquarePerimeter(a)}");
    }
    else if (fig == "rectangle")
    {
        Console.WriteLine("Enter values for a and b:");
        Console.Write("a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine($"Area: {RectangleArea(a, b)}");
        Console.WriteLine($"Perimeter: {RectanglePerimeter(a, b)}");
    }
    else if (fig == "circle") 
    {
        Console.WriteLine("Enter value for r:");
        Console.Write("r:");

        double r = double.Parse(Console.ReadLine());
        Console.WriteLine($"Area: {CircleArea(r)}");
    }
    else
    {
        Console.WriteLine("Invalid figure! Try again!");
    }
}
