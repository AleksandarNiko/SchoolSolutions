using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Performer
{
    public class Performer
    {
        private string firstName;
        private string lastName;
        private string genre;
        private byte albumsCount;

        public Performer(string firstName, string lastName, string genre, byte albumsCount)
        {
            FirstName = firstName;
            LastName = lastName;
            Genre = genre;
            AlbumsCount = albumsCount;
        }

        public Performer() 
        {

        }

        public string FirstName { get => firstName; set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                } 
                firstName = value;
            } 
        }

        public string LastName { get => lastName; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                firstName = value;
            }
        }

        public string Genre { get => genre; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                firstName = value;
            }
        }

        public byte AlbumsCount { get => albumsCount; set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid number!");
                }
                albumsCount = value;
            } 
        }

        public string IsGoldPerformer()
        {
            if(AlbumsCount > 50)
            {
                return "златен";
            }
            else if(AlbumsCount > 25 && AlbumsCount <= 50)
            {
                return "сребърен";
            }
            return "прохождащ";
        }

        public override string ToString()
        {
            return $"{Genre} – {AlbumsCount} – {FirstName} {LastName} \n" +
                $"Изпълнителят е: {IsGoldPerformer()}"
                .ToString();
        }
    }
}
