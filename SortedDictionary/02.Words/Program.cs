
string[] sequence = Console.ReadLine()!
    .Split(" ");

SortedDictionary<string, int> numCount = new SortedDictionary<string, int>();

for (int i = 0; i < sequence.Length; i++)
{
    var n = sequence[i];
    if (numCount.ContainsKey(n))
    {
        numCount[n]++;
    }
    else
    {
        numCount.Add(n, 1);
    }
}
Console.WriteLine();
foreach (var item in numCount)
{
    Console.WriteLine($"{item.Key}->{item.Value}");
}