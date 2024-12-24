
using _03.Parallelograms;

ParallelogramA parallelogramA = new ParallelogramA(7, 3, 30);

Console.WriteLine($"Area of ParallelogramA: {parallelogramA.Face()}");
Console.WriteLine($"Perimeter of ParallelogramA: {parallelogramA.Perimeter()}");

ParallelogramB parallelogramB = new ParallelogramB(3, 5, 50);
Console.WriteLine($"Area of ParallelogramB: {parallelogramB.Face()}");
Console.WriteLine($"Perimeter of ParallelogramB: {parallelogramB.Perimeter()}");
