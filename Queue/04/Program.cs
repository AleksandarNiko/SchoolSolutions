
var queue1 = new Queue<int>(new[] { 1, 3, 5, 7 });
var queue2 = new Queue<int>(new[] { 2, 4, 6, 8 });
var mergedQueue = Merge(queue1, queue2);

Console.WriteLine("Merged Queue:");
foreach (var item in mergedQueue)
{
    Console.WriteLine(item);
}

static Queue<int> Merge(Queue<int> queue1, Queue<int> queue2)
{
    var result = new Queue<int>();
    while (queue1.Count > 0 && queue2.Count > 0)
    {
        if (queue1.Peek() < queue2.Peek())
        {
            result.Enqueue(queue1.Dequeue());
        }
        else
        {
            result.Enqueue(queue2.Dequeue());
        }
    }

    while (queue1.Count > 0)
    {
        result.Enqueue(queue1.Dequeue());
    }

    while (queue2.Count > 0)
    {
        result.Enqueue(queue2.Dequeue());
    }

    return result;
}
