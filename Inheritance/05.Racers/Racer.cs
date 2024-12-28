using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Racers
{
    public class Racer : Person
    {
        private string startNumber;
        private List<int> points;

        public string StartNumber { get => startNumber; set => startNumber = value; }

        public List<int> Points { get => points; set => points = value; }

        public Racer(string firstName, string lastName, int birthDate,string startNumber) 
            : base(firstName, lastName, birthDate)
        {
            StartNumber = startNumber;
            Points = new List<int>();
        }

        public int AllScore()
        {
            return Points.Sum();
        }

        public string Grup(int yearNow)
        {
            int age = yearNow - BirthDate;

            string output = "";

            if (age < 14)
            {
                output = "юноши младша възраст";
            }
            else if (age >= 14 && age <= 18)
            {
                output = "юноши старша възраст";
            }
            else 
            {
                output = "професионалсти";
            }
            return output;
        }

        public override string ToString()
        {
            return $"Racer name: {FirstName} {LastName}, StartNumber: {StartNumber}, Points: {AllScore()}";
        }
    }
}
