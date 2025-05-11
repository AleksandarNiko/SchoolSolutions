using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.EliBooks
{
    public class Author
    {
        private string name;
        private string nationality;
        private string genre;

        public Author(string name,string nationality,string genre)
        {
            Name = name;
            Nationality = nationality;
            Genre = genre;
        }

        public string Name { get => name; set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                name = value;
            } 
        }

        public string Nationality { get => nationality; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                nationality = value;
            }
        }

        public string Genre { get => genre; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                genre = value;
            }
        }

        public override bool Equals(object obj)
        {
            var other = obj as Author;
            if (other.Name.Equals(Name) && other.Nationality.Equals(Nationality) && other.Genre.Equals(Genre)) 
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + Name.GetHashCode() + Nationality.GetHashCode() + Genre.GetHashCode();
            return hash;
        }

        public override string ToString()
        {
            return $"{Name}-{Nationality}: {Genre}";
        }
    }
}
