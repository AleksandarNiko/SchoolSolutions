
using _03.Restaurant;

Console.Write("Enter number of tables: ");
int n = int.Parse(Console.ReadLine());
var restaurant = new Restaurant();

for (int i = 0; i < n; i++)
{
    Console.Write("Enter table number: ");
    int tableNum = int.Parse(Console.ReadLine());
    Console.Write("Enter order number: ");
    int orderNum = int.Parse(Console.ReadLine());
    var items = new List<MenuItem>();

    while (true)
    {
        Console.Write("Enter food name (or 'end' to finish): ");
        string foodName = Console.ReadLine();
        if (foodName.ToLower() == "end") 
        {
            break;
        }

        Console.Write("Enter food price: ");
        decimal foodPrice = decimal.Parse(Console.ReadLine());
        items.Add(new MenuItem(foodName, foodPrice));
    }

    Order order = new Order(orderNum, items);
    restaurant.AddOrder(tableNum, order);
}

Console.WriteLine("\nOrders Summary:");
foreach (var table in restaurant.Orders)
{
    foreach (var order in table.Value)
    {
        Console.WriteLine(order.ToString());
    }
}

Console.Write("Enter order number to search: ");
int searchOrderId = int.Parse(Console.ReadLine());
Order foundOrder = restaurant.GetOrderById(searchOrderId);
if (foundOrder != null)
{
    Console.WriteLine("Found Order:");
    Console.WriteLine(foundOrder.ToString());
}
else
{
    Console.WriteLine("Order not found.");
}
