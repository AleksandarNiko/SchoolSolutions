
var numsInput=Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

var evens=new Stack<int>();
var odds = new Queue<int>();

foreach (int i in numsInput)
{
    if (i % 2 == 0)
    {
        evens.Push(i);
    }
    else
    {
        odds.Enqueue(i);
    }
}

Console.WriteLine($"Evens stack: {string.Join(" ",evens)}");
Console.WriteLine($"Odds stack: {string.Join(" ", odds)}");