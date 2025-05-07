
int n = 0;
var nums = new Stack<int>();

while ((n = int.Parse(Console.ReadLine())) != 0)
{
    nums.Push(n);
}
Console.WriteLine("Elements: ");
Console.WriteLine(string.Join(" ",nums));
Console.WriteLine("Reversed:");
while (nums.Count > 0)
{
    Console.Write(nums.Pop()+" ");
}


Console.WriteLine($"Count: {nums.Count}");
