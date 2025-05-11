
int n;
var queue = new Queue<int>();

while ((n = int.Parse(Console.ReadLine())) != 0)
{
    queue.Enqueue(n);
}

Console.WriteLine(string.Join(" ", queue));
Console.WriteLine("X: ");

int x = int.Parse(Console.ReadLine());
int count = 0;

if (queue.Contains(x))
{
    while (x != queue.Peek())
    {
        queue.Dequeue();
        count++;
    }
     
    Console.WriteLine("Count: " + count);
}
else
{
    Console.WriteLine("Nothing found!");
}
