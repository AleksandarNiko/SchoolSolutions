using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.Dentist
{
    public class Patient : Person
    {
        private int visitsCount;
        private bool ndok;

        public int VisitsCount { get => visitsCount; set => visitsCount = value; }

        public bool Ndok { get => ndok; set => ndok = value; }
        public Patient(string name, string dateOfBirth,int visitingsCount,bool ndok) 
            : base(name, dateOfBirth)
        {
            VisitsCount = visitingsCount;
            Ndok = ndok;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}; Date of birth: {this.DateOfBirth}; Visitings count: {VisitsCount}; НДОК: {Ndok}";
        }
    }
}
