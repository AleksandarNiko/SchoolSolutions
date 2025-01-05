
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);


double discriminant =Math.Sqrt((a * a) - (4 * a * b));

if (discriminant < 0)
{  
    Console.WriteLine("Няма реални решения.");
}
else if(discriminant > 0)
{
    double x1 = -sqrtDiscriminant;
    double x2 = sqrtDiscriminant;

    Console.WriteLine( $"Решенията са ({x1}; {x2}). ");
}
else
{
    Console.WriteLine();
}