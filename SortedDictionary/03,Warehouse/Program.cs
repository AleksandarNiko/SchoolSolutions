
SortedDictionary<string, int> productQuantity = new SortedDictionary<string, int>();
string input = "";
while((input=Console.ReadLine()!) != "buy")
{
    string[] lineToken = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    string name=lineToken[0];
    int quantity=int.Parse(lineToken[1]);

    if (productQuantity.ContainsKey(name))
    {
        productQuantity[name] += quantity;
    }
    else 
    {
        productQuantity.Add(name, quantity);
    }
}

foreach (var item in productQuantity)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}
