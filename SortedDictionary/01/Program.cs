

Random r = new Random();
SortedDictionary<int,int> numCount=new SortedDictionary<int,int>();

for(int i = 0; i < 20; i++)
{
    int n = r.Next(1, 10);
    Console.Write($"{n} ");
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
    Console.WriteLine($"{item.Key} - {item.Value} times.");
}