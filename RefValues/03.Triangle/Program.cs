
using _03.Triangle;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

List<Triangle> triangles = new List<Triangle>();
Console.WriteLine("Въведи брой триъгълници:");
byte count=byte.Parse(Console.ReadLine());

InputValues(triangles, 5);

PrintNamesAndHeights(triangles);

PrintPeremeters(triangles);

PrintNamesAndAreas(triangles);

//А)
static void InputValues(List<Triangle> triangles,byte count)
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine("Въведи инфо за триъгълник във формат: <име>,<страна А>,<страна Б>,<страна C>");
        string[] lineToken = Console.ReadLine().Split(",");
        string name=lineToken[0];
        double sideA=double.Parse(lineToken[1]);
        double sideB=double.Parse(lineToken[2]);
        double sideC=double.Parse(lineToken[3]);

        triangles.Add(new Triangle(name, sideA, sideB, sideC));
    }
}


//Б)
static void PrintNamesAndHeights(List<Triangle> triangles)
{
    foreach (Triangle triangle in triangles) 
    {
        Console.WriteLine($"Name: {triangle.Name}");
        Console.WriteLine($"Height: {triangle.HeightOfA()}");
    }
}

//В
static void PrintPeremeters(List<Triangle> triangles)
{
    List<double> perimeters=new List<double>();
    List<double> filteredPer = new List<double>();

    foreach (Triangle triangle in triangles)
    {
        perimeters.Add(triangle.Perimeter());
    }

    foreach (var item in perimeters) 
    {
        if (item > 10)
        {
            filteredPer.Add(item);
        }
    }
    Console.WriteLine("Периметри по-големи от 10:");
    Console.WriteLine(string.Join(",",filteredPer));

}

//Г)
static void PrintNamesAndAreas(List<Triangle> triangles)
{
    foreach (Triangle triangle in triangles)
    {
        Console.WriteLine($"Name: {triangle.Name}");
        Console.WriteLine($"Area: {triangle.Area()}");
    }
}
