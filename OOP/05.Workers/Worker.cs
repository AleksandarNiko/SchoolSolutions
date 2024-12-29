using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _05.Workers
{
    public class Worker
    {
        public  string Name { get; set; }

        public  string Work { get; set; }

        public  int Hours { get; set; }

        public  decimal Money { get; set; }

       

        public override string ToString()
        {
            return $"Name: {Name}; Work: {Work}; Work hours: {Hours}; Salary: {Hours * Money}lv"
                .ToString()
                .Trim();
        }
    }
}
