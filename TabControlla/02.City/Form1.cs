using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02.City
{
    public partial class Form1 : Form
    {
        HashSet<City> cities = new HashSet<City>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name=textBox1.Text.ToLower();
            int population=int.Parse(textBox2.Text);
            int postcode=int.Parse(textBox3.Text);
            bool isRegional = false;

            if (radioButton1.Checked) 
            {
                isRegional = true;
            }

            City city = new City(name, population, postcode, isRegional);

            cities.Add(city);
            listBox1.Items.Add($"New city added: {city.Name}");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string currName=textBox4.Text.ToLower();
            var currCity = cities.FirstOrDefault(c=>c.Name==currName);

            if (currCity != null)
            {
                label6.Text = $"Found city: {currCity.ToString()}!";
            }
            else
            {
                label6.Text = "Nothing found!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int currPostCode=int.Parse(textBox5.Text);

            var currCity = cities.FirstOrDefault(c => c.PostCode == currPostCode);

            if (currCity != null)
            {
                label8.Text = $"Found city: {currCity.ToString()}!";
            }
            else
            {
                label8.Text = "Nothing found!";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var regionals=cities
                .Where(c=>c.IsRegional==true)
                .ToList();

            foreach (var region in regionals)
            {
                listBox2.Items.Add(region.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var orderedCities=cities.OrderBy(c=>c.Name);

            foreach(var c in orderedCities)
            {
                listBox3.Items.Add(c.ToString());
            }
        }
    }
}
