using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Library
{
    using System;

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool Availability { get; set; } 

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Availability = true; 
        }

        public void CheckOut()
        {
            if (Availability)
            {
                Availability = false;
                Console.WriteLine($"Книгата '{Title}' е заета.");
            }
            else
            {
                Console.WriteLine($"Книгата '{Title}' е вече заета.");
            }
        }

        public void ReturnBook()
        {
            if (!Availability)
            {
                Availability = true;
                Console.WriteLine($"Книгата '{Title}' е върната.");
            }
            else
            {
                Console.WriteLine($"Книгата '{Title}' не е била заета.");
            }
        }
    }

}
