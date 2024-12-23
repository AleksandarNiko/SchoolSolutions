

using _01.Pets;

Cat cat = new Cat()
{
    Name = "Rosko kotkata"
};
cat.Act();
Console.WriteLine(cat.Eat());

Fish fish = new Fish()
{
    Name = "Zlatko ribata"
};
fish.Act();
Console.WriteLine(fish.Eat());