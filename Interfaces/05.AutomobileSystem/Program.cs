using _05.AutomobileSystem;

Car car = new Car();
Console.WriteLine("При въведена команда – D – колата се движи");
Console.WriteLine("При въведена команда – R – колата се зарежда.");

while (true)
{
    Console.WriteLine("Въведи команда:");
    string input = Console.ReadLine().ToUpper();

    if (input == "D")
    {
        car.Drive();
    }
    else if (input == "R")
    {
        car.Refuel();
    }
    else
    {
        Console.WriteLine("Невалидна команда!");
    }
    Console.WriteLine();
}

