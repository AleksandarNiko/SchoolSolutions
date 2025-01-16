using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BoxProject
{
    public class Box_All<T>
    {
        private List<T> _data;

        public Box_All()
        {
            _data = new List<T>();
        }

        public void Add_box(T element)
        {
            _data.Add(element);
        }

        public T Remove_box() 
        {
            _data.Remove(_data.Last());
            return _data.Last();
        }

        public  int Count { get; }

        public void Display()
        {
            foreach (var item in _data)
            {
                Console.WriteLine(item);
            }
        }

    }
}
