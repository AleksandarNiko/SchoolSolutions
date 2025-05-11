
Queue<string> queue = new Queue<string>(new[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" });
Stack<string> stack = new Stack<string>();

while (queue.Count > 0)
{
    stack.Push(queue.Dequeue());
    if (queue.Count > 0)
    {
        queue.Enqueue(queue.Dequeue()); 
    }
}

Console.WriteLine("Stack:");
foreach (var item in stack)
{
    Console.WriteLine(item);
}
