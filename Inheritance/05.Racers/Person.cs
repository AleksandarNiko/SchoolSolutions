using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Racers
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int birthDate;

        public Person(string firstName, string lastName, int birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public string FirstName { get => firstName; set => firstName = value; }

        public string LastName { get => lastName; set => lastName = value; }

        public int BirthDate { get => birthDate; set => birthDate = value; }
    }
}
