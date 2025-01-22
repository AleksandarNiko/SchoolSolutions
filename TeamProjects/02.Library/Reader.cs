using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Library
{
    using System.Collections.Generic;

    public class Reader : Person
    {
        private List<Book> booksCheckedOut;
        public int MaxBooks { get; set; }

        public Reader(string name, string id, string email, int maxBooks = 5)
            : base(name, id, email)
        {
            booksCheckedOut = new List<Book>();
            MaxBooks = maxBooks;
        }

        public void CheckOutBook(Book book)
        {
            if (booksCheckedOut.Count >= MaxBooks)
            {
                Console.WriteLine($"{Name} не може да заеме повече от {MaxBooks} книги едновременно.");
                return;
            }

            if (book.Availability)
            {
                book.CheckOut();
                booksCheckedOut.Add(book);
            }
            else
            {
                Console.WriteLine($"Книгата '{book.Title}' не е налична за заемане.");
            }
        }

        public void ReturnBook(Book book)
        {
            if (booksCheckedOut.Contains(book))
            {
                book.ReturnBook();
                booksCheckedOut.Remove(book);
            }
            else
            {
                Console.WriteLine($"Книгата '{book.Title}' не е заета от {Name}.");
            }
        }
    }

}
