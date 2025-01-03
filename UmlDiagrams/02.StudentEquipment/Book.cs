using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentEquipment
{
    public class Book
    {
        private string name;
        private double weight;

        public Book(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
    }
}
