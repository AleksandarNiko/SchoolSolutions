using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.EliBooks
{
    public class Book
    {
        private string name;

        public Book(string name)
        {
            Name = name;
        }

        public string Name
        {
            get => name; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                name = value;
            }
        }

    }
}
