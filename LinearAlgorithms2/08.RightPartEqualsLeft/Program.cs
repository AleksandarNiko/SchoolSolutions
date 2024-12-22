

for (int i = 100; i < 1000; i++)
{
    int rightTwoDigits=i % 100;
    int firstDigit = i / 100;
    
    if(Math.Pow(firstDigit, 2) == rightTwoDigits)
    {
        Console.WriteLine(i);
    }
}
