using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pot
{
    public class Pot : IHouseholdCourt
    {
        private double currentQuantity;
        private double capacity;

        public double Capacity { get => capacity;  set => capacity = value; }

        public double CurrentQuantity { get => currentQuantity; set => currentQuantity = value; }

        public void Add(double quantity)
        {
            if (quantity + CurrentQuantity > capacity)
            {
                Console.WriteLine($"That's too much quantity: {quantity}!");
            }
            else 
            {
                CurrentQuantity += quantity;
            }
        }

        public bool IsFull()
        {
            return currentQuantity == capacity ? true : false;
        }

        public void Taking(double quantity)
        {
            if (CurrentQuantity - quantity < 0 || quantity > Capacity) 
            {
                Console.WriteLine($"You cannot take this quantity: {quantity}");
            }
            else
            {
                CurrentQuantity -= quantity;
            }
        }
    }
}
