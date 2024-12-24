
using _01.Shop;
using static _01.Shop.Shop;

string input = "";
while (true)
{
    input=Console.ReadLine();
    if(input == "END")
    {
         break;
    }
    string[] lineToken = input.Split(" ");

    string command=lineToken[0];

    if (command == "Add")
    {
        string code = lineToken[1];
        string name = lineToken[2];
        decimal price = decimal.Parse(lineToken[3]);
        double quantity = double.Parse(lineToken[4]);

        Add(code, name, price, quantity);
    }
    else if (command == "Update")
    {
        string code = lineToken[1];
        double quantity = double.Parse(lineToken[2]);

        ProductLoading(code, quantity);
    }
    else if(command == "Sell")
    {
        string code=lineToken[1];
        double quantity = double.Parse(lineToken[2]);

        Sale(code, quantity);
    }
    else if(command== "Calculate")
    {
        AvailableProductsSum();
    }
    else if( command == "PrintA")
    {
        AllProducts();
    }
    else if(command== "PrintU")
    {
        UnavailableProducts();
    }
    else if(command== "PrintD")
    {
        AvailableProducts();
    }
}
