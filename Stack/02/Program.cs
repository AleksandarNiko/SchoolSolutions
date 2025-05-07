
Console.WriteLine("Enter a number:");
int num = int.Parse(Console.ReadLine());

string binaryResult = ConvertToBinary(num);
Console.WriteLine($"Binary: {binaryResult}");

Console.WriteLine("Enter a base (2-9):");
int baseNum = int.Parse(Console.ReadLine());

if (baseNum >= 2 && baseNum <= 9)
{
    string customBaseResult = ConvertToBase(num, baseNum);
    Console.WriteLine($"Base {baseNum}: {customBaseResult}");
}
else
{
    Console.WriteLine("Base must be between 2 and 9.");
}


static string ConvertToBinary(int num)
{
    var stack = new Stack<int>();
    while (num > 0)
    {
        stack.Push(num % 2);
        num /= 2;
    }

    return string.Join("", stack);
}

static string ConvertToBase(int num, int baseNumber)
{
    var stack = new Stack<int>();
    while (num > 0)
    {
        stack.Push(num % baseNumber);
        num /= baseNumber;
    }

    return string.Join("", stack);
}
