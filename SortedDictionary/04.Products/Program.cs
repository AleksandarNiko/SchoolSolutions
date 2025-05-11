
Dictionary<string, (decimal price, int quantity)> products = new Dictionary<string, (decimal, int)>();
string input=" ";

while ((input = Console.ReadLine()!.ToLower()) != "buy")
{
    var lineToken = input.Split(' ');
    string name = lineToken[0];
    decimal price = decimal.Parse(lineToken[1]);
    int quantity = int.Parse(lineToken[2]);

    if (products.ContainsKey(name))
    {
        products[name] = (price, products[name].quantity + quantity);
    }
    else
    {
        products[name] = (price, quantity);
    }
}

var totalPrices = new SortedDictionary<string, decimal>();

foreach (var product in products)
{
    totalPrices[product.Key] = product.Value.price * product.Value.quantity;
}

foreach (var product in totalPrices)
{
    Console.WriteLine($"{product.Key} -> {product.Value}");
}
