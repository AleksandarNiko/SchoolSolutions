

using _02.TrianglesWorld;
using System.IO;

List<EquilateralTriangle> equilateralTriangles = new List<EquilateralTriangle>();
List <ScaleneTriangle> scaleneTriangles = new List<ScaleneTriangle>();

string input = "";
while (input != "FINISH")
{
    input=Console.ReadLine();
    if(input == "FINISH")
    {
        break;
    }

    string[] lineToken = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    if(lineToken.Length == 2)
    {
        string name = lineToken[0];
        double side=double.Parse(lineToken[1]);
        equilateralTriangles.Add(new EquilateralTriangle(name, side));
    }
    else if (lineToken.Length == 4) 
    {
        string name = lineToken[0];
        double sideA = double.Parse(lineToken[1]);
        double sideB = double.Parse(lineToken[2]);
        double sideC = double.Parse(lineToken[3]);
        double heightA = double.Parse(lineToken[4]);
        scaleneTriangles.Add(new ScaleneTriangle(name, sideA, sideB, sideC, heightA));
    }
}

Console.WriteLine("Равностранни триъгълници:");
foreach (var triangle in equilateralTriangles)
{
    Console.WriteLine($"Име: {triangle.Name}, Периметър: {triangle.Perimeter():f2}, Лице: {triangle.Area():f2}");
}

Console.WriteLine("Разностранни триъгълници:");
foreach (var triangle in scaleneTriangles)
{
    Console.WriteLine($"Име: {triangle.Name}, Периметър: {triangle.Perimeter():f2}, Лице: {triangle.Area():f2}");
}