Console.WriteLine("Въведи координатите на едната точка (x1, y1):");
string[] point1 = Console.ReadLine().Split(',');
double x1 = double.Parse(point1[0]);
double y1 = double.Parse(point1[1]);

Console.WriteLine("Въведи координатите на втората точка (x2, y2):");
string[] point2 = Console.ReadLine().Split(',');
double x2 = double.Parse(point2[0]);
double y2 = double.Parse(point2[1]);

double a = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
double b = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
double c = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

double p = (a + b + c) / 2;

double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

Console.WriteLine($"Area: {area}");

