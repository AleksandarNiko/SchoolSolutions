using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Library
{
    public class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Email { get; set; }

        public Person(string name, string id, string email)
        {
            Name = name;
            ID = id;
            Email = email;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Име: {Name}, ID: {ID}, Имейл: {Email}");
        }
    }

}
