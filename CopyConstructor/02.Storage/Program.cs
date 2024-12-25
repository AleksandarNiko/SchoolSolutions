
using _02.Storage;

StorageForProducts storageForProducts = new StorageForProducts();

string input = "";

while (input != "FINISH")
{
    input = Console.ReadLine()!;
    if (input == "FINISH")
    {
        break;
    }
    string[] lineToken = input.Split(" ");
    string command = lineToken[0];

    if (command == "Add")
    {
        string name = lineToken[1];
        int quantity = int.Parse(lineToken[2]);
        storageForProducts.Add(new Product(name, quantity));
    }
    else if(command == "Delivery")
    {
        string name = lineToken[1];
        int quantity = int.Parse(lineToken[2]);
        storageForProducts.Delivery(new Product(name, quantity));
    }
    else if( command == "Sale")
    {
        string name = lineToken[1];
        int quantity = int.Parse(lineToken[2]);
        storageForProducts.Sale(new Product(name, quantity));
    }
    else if(command == "Print")
    {
        Console.WriteLine(storageForProducts.ToString()); 
    }
}