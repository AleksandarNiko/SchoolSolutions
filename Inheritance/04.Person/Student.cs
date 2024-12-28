using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Person
{
    public class Student : Person
    {
        private double grade;
        private string studentClass;

        public double Grade { get => grade; set 
            {
                if(value< 0)
                {
                    throw new ArgumentException("Grade cannot be negative number!");
                }
                grade = value;
            }
        }
        public string Class { get => studentClass; set 
            {
                if (string.IsNullOrEmpty(value) || value.Length != 2) 
                {
                    throw new ArgumentException("Class name cannot be null and should have 2 chars!");
                }
                studentClass = value;
            }
        }
        public Student(string name, string id,double grade,string clas) 
            : base(name, id)
        {
            Grade= grade;
            Class= clas;
        }

        public override string ToString()
        {
            return $"Name: {Name}, EGN: {Id}, Average Grade: {Grade}, Class: {Class}";
        }
    }
}
