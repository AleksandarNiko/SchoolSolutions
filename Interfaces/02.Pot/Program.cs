

using _02.Pot;

Pot pot = new Pot()
{
    Capacity = 100,
    CurrentQuantity = 20
};

string input = "";

while (input != "End")
{
    input = Console.ReadLine();
    if(input == "End")
    {
        break;
    }
    string[] lineToken = input.Split(" ");
    string command=lineToken[0];
    double quantity=double.Parse(lineToken[1]);

    if (command == "Add")
    {
        pot.Add(quantity);
    }
    else if(command == "Taking")
    {
        pot.Taking(quantity);
    }
    else 
    {
        Console.WriteLine("Invalid command!");
    }
}

if (pot.IsFull() == true)
{
    Console.WriteLine($"{pot.CurrentQuantity} - пълна тенджера.");
}
else
{
    Console.WriteLine($"{pot.CurrentQuantity} - празна тенджера.");
}