
using _04.BusTicket;
using static _04.BusTicket.BusTicket;

Console.WriteLine("Въвеждайте информация във формат: <от> <до> <цена на билета> <име на клиента>");
Console.WriteLine("Въведи end  за край");
string input = "";
while (input != "END")
{
    input = Console.ReadLine().ToUpper();
    if(input == "END") 
    {
        break;
    }
    string[] lineToken = input.Split();
    string from=lineToken[0];
    string to=lineToken[1];
    decimal price=decimal.Parse(lineToken[2]);
    string clientName=lineToken[3];
    BusTicket ticket=new BusTicket(from, to, price, clientName);
}

Console.WriteLine($"Sold tickets: {TicketsCount}");
Console.WriteLine($"Sum of sold products: {TicketsPricesSum}");
