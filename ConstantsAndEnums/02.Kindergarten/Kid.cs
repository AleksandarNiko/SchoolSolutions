using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Kindergarten
{
    public class Kid
    {
        public Kid(string firstName, string middleName, string lastName, string birthDate, byte age, TypeGroup typeGroup)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            BirthDate = birthDate;
            Age = age;
            TypeGroup = typeGroup;
        }

        public  string FirstName { get; set; }

        public  string MiddleName { get; set; }

        public  string LastName { get; set; }

        public  string BirthDate { get; set; }

        public  byte Age { get; set; }

        public TypeGroup TypeGroup { get; set; }
    }
}

public enum TypeGroup
{
    МечоПух,
    Гъбарко, 
    Светулка, 
    Усмивка
}
