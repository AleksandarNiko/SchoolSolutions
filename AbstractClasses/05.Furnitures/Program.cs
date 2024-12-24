using _05.Furnitures;

List<Furniture> furnitures = new List<Furniture>();

string input = "";
while (true)
{   
    input=Console.ReadLine();
    if (input == "END")
    {
        break;
    }

    string[] inputArgs = input.Split();
    FurnitureType furnitureType = Enum.Parse<FurnitureType>(inputArgs[0]);
    string name = inputArgs[1];

    if (furnitureType == FurnitureType.Chair)
    {
        string color = inputArgs[2];
        string size = inputArgs[3];
        decimal priceToMake = decimal.Parse(inputArgs[4]);
        furnitures.Add(new Chair(furnitureType, priceToMake, color, size));
    }
    else if (furnitureType == FurnitureType.Table)
    {
        string kind = inputArgs[2];
        decimal priceToMake = decimal.Parse(inputArgs[3]);
        furnitures.Add(new Table(furnitureType, priceToMake, kind));
    }
}

Console.WriteLine("Furnitures:");
foreach (var furniture in furnitures)
{
    Console.WriteLine(furniture.Name);
}

Console.WriteLine("Tables:");
foreach (var furniture in furnitures)
{
    if (furniture.Name == FurnitureType.Table)
    {
        Console.WriteLine(furniture.ToString());
        Console.WriteLine($"Distributor price: {furniture.PriceDistributor():f2}");
    }
}

Console.WriteLine("Chairs:");
foreach (var furniture in furnitures)
{
    if (furniture.Name == FurnitureType.Chair)
    {
        Console.WriteLine(furniture.ToString());
        Console.WriteLine($"Distributor price: {furniture.PriceDistributor():f2}");
    }
}

decimal startPrice=decimal.Parse(Console.ReadLine());
decimal endPrice = decimal.Parse(Console.ReadLine());
Console.WriteLine("Furnitures in price range:");
foreach (var furniture in furnitures)
{
    if (furniture.PriceClient() >= startPrice && furniture.PriceClient() <= endPrice)
    {
        Console.WriteLine(furniture.ToString());
        Console.WriteLine($"Price: {furniture.PriceClient():f2}");
    }
}
