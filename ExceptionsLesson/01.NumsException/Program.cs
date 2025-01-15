try
{
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    double result = num1 / num2;

    Console.WriteLine(result);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}