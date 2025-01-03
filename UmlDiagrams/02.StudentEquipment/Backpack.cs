using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentEquipment
{
    public class Backpack
    {
        public List<Book> Books { get; set; }

        public List<Notebook> NoteBooks { get; set; }

        public Backpack()
        {
            Books = new List<Book>();
            NoteBooks = new List<Notebook>();
        }

        public double AllWeight()
        {
            double sum = 0;
            foreach (Book book in Books) 
            {
                sum += book.Weight;
            }
            foreach (Notebook book in NoteBooks)
            {
                sum += book.Weight;
            }
            return sum;
        }

        public override string ToString()
        {
            return $"Раницата с {Books.Count}бр. учебници и {NoteBooks.Count}бр. тетрадки тежи {AllWeight()}кг.";
        }
    }
}
