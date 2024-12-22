//Използвам byte, защото този тип данни е от 0 до 255

Random r =new Random();
byte number = (byte)r.Next(0, 100);

if (number == 0 || number == 1)
{
    Console.WriteLine($"{number} не е просто число.");
}
else
{
    for (int i = 2; i <= number / 2; i++)
    {
        if (number % i == 0)
        {
            Console.WriteLine($"{number} не е просто число.");
            return;
        }

    }
    Console.WriteLine($"{number} е просто число.");
}
