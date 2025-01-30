using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _01.Children_sRoom
{
    public class Teacher
    {
        private string name;
        private string specialty;
        public Teacher(string name, string specialty)
        {
            Name = name;
            Specialty = specialty;
            Groups = new List<Group> ();
        }

        public  string Name { get=>name; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null!");
                }
                name = value;
            }
        }

        public  string Specialty { get=> specialty; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null!");
                }
                specialty = value;
            }
        }

        public  List<Group> Groups { get; set; }
    }
}
