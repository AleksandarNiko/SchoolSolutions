using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Card
{
    public class Card
    {
        private string name;
        private string author;
        private int avaliavableCardsCount;

        public string Name { get => name; set=>name=value; }

        public string Author { get=>author; set=>author=value; }
        public  int AvaliavableCardsCount { get=>avaliavableCardsCount; set=>avaliavableCardsCount=value; }

        public void PrintInformation()
        {
            Console.WriteLine($"Book: {Name}; Author: {Author}; Cards: {AvaliavableCardsCount}");
        }
    }
}
