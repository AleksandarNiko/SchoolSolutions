
int n=int.Parse(Console.ReadLine());
int sumOfAllNums = 0;
if (n < 5)
{
    Console.WriteLine("Invalid input!");
}
else
{
    for (int i = 0; i < n; i++)
    {
        int currSum = 0;
        for (int j = 1; j <= i; j++)
        {
            currSum *= j;
            sumOfAllNums += currSum;
        }
    }

    Console.WriteLine(sumOfAllNums);
}
