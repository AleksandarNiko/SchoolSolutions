
int number=int.Parse(Console.ReadLine());

for (int i = 100; i < 1000; i++)
{
    int firstDigit = (i / 100);
    int secondDigit = ((i / 10) % 10);
    int thirdDigit = (i % 10);

    int sum = firstDigit + secondDigit + thirdDigit;

    if (sum == number)
    {
        Console.WriteLine(i);
    }
}
