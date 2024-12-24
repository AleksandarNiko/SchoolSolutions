using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Phones
{
    public class Phone
    {
        private string model;
        private string maker;
        private decimal price;
        private DateTime createdOn;

        public Phone(string model, string maker, decimal price, DateTime createdOn)
        {
            Model = model;
            Maker = maker;
            Price = price;
            CreatedOn = createdOn;
        }

        public string Model { get => model; set => model = value; }

        public string Maker { get => maker; set => maker = value; }

        public decimal Price { get => price; set => price = value; }

        public DateTime CreatedOn { get => createdOn; set => createdOn = value; }

        //public override string ToString()
        //{
        //    return $"Model: {Model}; Maker: {Maker}; Price: {Price}; CreatedOn: {CreatedOn.ToString("dd//MM/yyyy")}";
        //}
    }
}