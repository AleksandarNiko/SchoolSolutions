
Console.Write("Въведи число: ");
double number = double.Parse(Console.ReadLine());
Console.Write("Въведи степен: ");
int power = int.Parse(Console.ReadLine());

var result=Pow(number, power);

Console.WriteLine($"Резултат: {result}");

static double Pow(double number, int power)
{
    if (power == 0)
    {
        return 1;
    }
    else if (power < 0)
    {
        return 1 / Pow(number, -power);
    }
    else
    {
        return number * Pow(number, power - 1);
    }
}
