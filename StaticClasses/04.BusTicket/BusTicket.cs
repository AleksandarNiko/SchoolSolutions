using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BusTicket
{
    public class BusTicket
    {
        private static int ticketsCount;
        private static decimal ticketsPricesSum;

        public BusTicket(string from, string to, decimal price, string clientName)
        {
            From = from;
            To = to;
            Price = price;
            ClientName = clientName;
            TicketsCount++;
            TicketsPricesSum += price;
        }

        public static int TicketsCount { get => ticketsCount; set => ticketsCount = value; }
        public static decimal TicketsPricesSum { get => ticketsPricesSum; set => ticketsPricesSum = value; }
        public  string From { get; set; }

        public  string To { get; set; }

        public  decimal Price { get; set; }

        public  string ClientName { get; set; }
    }
}
