using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTest
{
    public class Song
    {
        private string name;
        private string genre;
        private byte rating;
        private string singer;

        public Song(string name, string genre, byte rating)
        {
            Name = name;
            Genre = genre;
            Rating = rating;
        }

        public string Name { get => name; set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null!");
                }
                name = value;
            } 
        }

        public string Genre { get => genre; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Genre cannot be null!");
                }
                genre = value;
            }
        }

        public byte Rating { get => rating; set 
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("Rating cannot be less that 1 or more than 10!");
                }
                rating = value;
            } 
        }

        public string Singer { get => singer; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Singer name cannot be null!");
                }
                singer = value;
            }
        }
    }
}
