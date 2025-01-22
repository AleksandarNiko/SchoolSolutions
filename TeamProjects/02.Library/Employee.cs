using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Library
{
    public class Employee : Person
    {
        public string Role { get; set; }

        public Employee(string name, string id, string email, string role)
            : base(name, id, email)
        {
            Role = role;
        }

        public void AddNewBook(Book book, Library library)
        {
            library.AddBook(book);
            Console.WriteLine($"Книга '{book.Title}' добавена от {Name}.");
        }

        public void RemoveBook(Book book, Library library)
        {
            library.RemoveBook(book);
            Console.WriteLine($"Книга '{book.Title}' премахната от {Name}.");
        }
    }

}
