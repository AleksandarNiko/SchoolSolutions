try
{
    Console.Write("Enter grade: ");
    double grade = double.Parse(Console.ReadLine());
    if (grade < 3 || grade > 6)
    {
        throw new ArgumentOutOfRangeException();
    }

    if (grade > 5.50)
    {
        Console.WriteLine("Scholarship");
    }
    else
    {
        Console.WriteLine("No scholarship");
    }
}
catch (FormatException)
{
    Console.WriteLine("Invalid number");
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("Invalid grade");
}

