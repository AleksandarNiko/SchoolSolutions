
var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

Stack<int> stack = new Stack<int>(); 

foreach  (var item in nums)
{
    stack.Push(item);
}

int x=int.Parse(Console.ReadLine());

int index=