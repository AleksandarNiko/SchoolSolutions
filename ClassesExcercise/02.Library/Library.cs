using _01.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Library
{
    public class Library
    {
        private string name;
        private string city;

        public Library(string name, string city)
        {
            Name = name;
            City = city;
            Books=new List<Book>();
        }

        public string Name { get => name; set => name = value; }

        public string City { get => city; set => city = value; }

        public List<Book> Books { get; set; }

        public void AddBook(Book book) 
        {
            Books.Add(book);
        }

        public Book FindBookByName(string name)
        {
            return Books.FirstOrDefault(x => x.Name == name)!;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Books:");
            foreach (Book book in Books) 
            {
                sb.AppendLine(book.ToString());
            }
            return sb.ToString();
        }

        public Book FindBookByAuthor(string author)
        {
            return Books.FirstOrDefault(x => x.Author == author)!;
        }
    }
}
