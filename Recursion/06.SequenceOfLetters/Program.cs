
Console.Write("Enter the value of n: ");
int n = int.Parse(Console.ReadLine());
Sequence(n);

static void Sequence(int n)
{
    Console.Write('A');
    if(n>1)
    {
        Sequence(n-1);
    }
    Console.Write('B');
}


