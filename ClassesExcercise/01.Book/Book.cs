using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Book
{
    public class Book
    {
        private string name;
        private string author;
        private string genre;

        public Book(string name, string author, string ganre)
        {
            Name = name;
            Author = author;
            Genre = ganre;
        }

        public string Name { get => name; private set => name = value; }

        public string Author { get => author;private  set => author = value; }

        public string Genre { get => genre; private set => genre = value; }

        public override string ToString() 
        {
            return $"Name: {Name}; Author: {Author}; Genre: {Genre}";
        }
    }
}
