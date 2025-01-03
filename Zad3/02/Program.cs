
int n=int.Parse(Console.ReadLine()!);
double sum = 1;
for (int i=0; i<n; i++)
{
   int currNum= int.Parse(Console.ReadLine()!);
    if (currNum < 0)
    {
        sum *= currNum;
    }
}

Console.WriteLine($"Произведението на отрицателните числа е: {sum}");


