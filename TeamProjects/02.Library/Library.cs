using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Library
{
    using System.Collections.Generic;

    public class Library
    {
        private List<Book> books;
        private List<Reader> readers;
        private List<Employee> employees;

        public Library()
        {
            books = new List<Book>();
            readers = new List<Reader>();
            employees = new List<Employee>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            if (books.Contains(book))
            {
                books.Remove(book);
            }
            else
            {
                Console.WriteLine($"Книгата '{book.Title}' не се намира в библиотеката.");
            }
        }

        public void AddReader(Reader reader)
        {
            readers.Add(reader);
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public List<Book> GetAvailableBooks()
        {
            var foundBooks=new List<Book>();

            foreach (var book in books)
            {
                if (book.Availability)
                {
                    foundBooks.Add(book);
                }
            }

            return foundBooks;
        }

        public void GetBooksStatus()
        {
            foreach (var book in books)
            {
                string status = book.Availability ? "Налична" : "Заета";
                Console.WriteLine($"Заглавие: {book.Title}, Автор: {book.Author}, Статус: {status}");
            }
        }
    }

}
