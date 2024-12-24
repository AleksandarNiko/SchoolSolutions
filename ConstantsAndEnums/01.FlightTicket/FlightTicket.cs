using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FlightTicket
{
    public class FlightTicket
    {
        private static int ticketsSold = 0;
        private const int MaxPassengers = 100;

        public string PassengerFirstName { get; set; }
        public string PassengerLastName { get; set; }
        public string SeatLocation { get; private set; }

        public FlightTicket(string firstName, string lastName)
        {
            if (ticketsSold >= MaxPassengers)
            {
                Console.WriteLine("Maximum number of passengers reached. Ticket cannot be issued.");
                return;
            }

            PassengerFirstName = firstName;
            PassengerLastName = lastName;
            SeatLocation = GenerateSeatLocation();
            ticketsSold++;
        }

        private string GenerateSeatLocation()
        {
            return $"Seat {ticketsSold + 1}";
        }
    }
}
