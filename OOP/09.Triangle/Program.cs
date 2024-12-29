
using _09.Triangle;

string name = Console.ReadLine();
double a=double.Parse(Console.ReadLine());
double b=double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());

static bool areValidSides(double a, double b, double c)
{
    if((a < b + c && 
        b < a + c && 
        c < a + b) && (a > 0 && b > 0 && c > 0))
    {
        return true;
    }
    return false;
}

if(areValidSides(a, b, c) == true)
{
    Triangle triangle =new Triangle(name,a,b,c);
    Console.WriteLine(triangle.ToString());
}
else
{
    Console.WriteLine("Invalid sides!");
}