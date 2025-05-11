using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03.RestaurantVisual
{
    public partial class Form1 : Form
    {
        Restaurant restaurant;
        public Form1()
        {
            InitializeComponent();
            restaurant = new Restaurant();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int orderId = int.Parse(textBox1.Text);

            var currOrder=restaurant.GetOrderById(orderId);

            if (currOrder != null)
            {
                MessageBox.Show(currOrder.ToString());
            }
            else
            {
                MessageBox.Show("Nothing found!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tableNumber = int.Parse(textBox2.Text);
            int orderNumber = int.Parse(textBox3.Text);
            var items = new List<MenuItem>();

            while (true)
            {
                string foodName = textBox4.Text;
                if (string.IsNullOrEmpty(foodName)) 
                {
                    break;
                }

                decimal price = decimal.Parse(textBox5.Text);
                items.Add(new MenuItem(foodName, price));
            }

            Order order = new Order(orderNumber, items);
            restaurant.AddOrder(tableNumber, order);
            MessageBox.Show("Order added successfully!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var table in restaurant.Orders)
            {
                foreach (var order in table.Value)
                {
                    MessageBox.Show(order.ToString());
                }
            }
        }
    }
}
