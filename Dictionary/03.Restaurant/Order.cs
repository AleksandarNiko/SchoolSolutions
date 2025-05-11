using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant
{
    public class Order
    {
        public Order(int orderId,List<MenuItem> items)
        {
            OrderId = orderId;
            Items = items;
        }

        public Order() { }

        public  int OrderId { get; set; }
        public  List<MenuItem> Items { get; set; }

        public  decimal TotalPrice => CalculateTotalPrice();

        private decimal CalculateTotalPrice()
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.Price;
            }
            return total;
        }

        public override string ToString()
        {
            var sb=new StringBuilder();
            sb.AppendLine($"Order: {OrderId}");
            sb.AppendLine($"Price оrder:{TotalPrice:f2}");
            return sb.ToString().Trim();
        }

    }
}