
var nums=Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

var path = "result.txt";

int k=int.Parse(Console.ReadLine());

var sortedNums = nums
    .OrderBy(n => SumOfDigits(n)).ToList();

Console.WriteLine("\nСортирани по сума от цифрите:");
Console.WriteLine(string.Join(" ", sortedNums));

var filteredNums = sortedNums
    .Where(n => SumOfDigits(n) % k != 0)
    .ToList();

Console.WriteLine("Филтрирани:");
Console.WriteLine(string.Join(" ", filteredNums));



using (StreamWriter writer = new StreamWriter(path))
{
    writer.WriteLine("Входящ списък:");
    writer.WriteLine(string.Join(" ", nums));

    writer.WriteLine("\nНов списък:");
    writer.WriteLine(string.Join(" ", filteredNums));
}

static int SumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}


