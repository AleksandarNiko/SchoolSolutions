using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RestaurantVisual
{
    public class Restaurant
    {
        public Dictionary<int, List<Order>> Orders { get; set; } 
            = new Dictionary<int, List<Order>>();

        public void AddOrder(int IdTable, Order order)
        {
            if (!Orders.ContainsKey(IdTable))
            {
                Orders[IdTable] = new List<Order>();
            }
            Orders[IdTable].Add(order);
        }

        public Order GetOrderById(int OrderId)
        {
            foreach (var orders in Orders.Values)
            {
                foreach (var order in orders)
                {
                    if (order.OrderId == OrderId)
                    {
                        return order;
                    }
                }
            }
            return null;
        }
    }
}