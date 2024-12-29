
using _06.Product;
using System.Text.RegularExpressions;
using System.Xml.Linq;

Product[] products=new Product[5];

for(int i = 0; i < 5; i++)
{
    string name = Console.ReadLine()!;
    string group = Console.ReadLine()!;
    string unitOfMeasurement = Console.ReadLine()!;
    decimal arrivePrice = decimal.Parse(Console.ReadLine()!);
    products[i] = new Product(name, group, unitOfMeasurement, arrivePrice);
}

foreach  (Product product in products)
{
    Console.WriteLine(product.ToString());
}

var productWithBiggestIncome = products.OrderByDescending(p => p.ArrivePrice).First();

Console.WriteLine(productWithBiggestIncome.ToString());