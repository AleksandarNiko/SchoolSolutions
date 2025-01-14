using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoShop
{
    public partial class Form1 : Form
    {
        private List<SparePart> spareParts;
        private List<Car> cars;
        private List<ManufacturerCompany> companies;
        public Form1()
        {
            InitializeComponent();
            spareParts = new List<SparePart>();
            cars = new List<Car>();
            companies = new List<ManufacturerCompany>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            string categoryString=textBox1.Text;
            Category category = (Category)Enum.Parse(typeof(Category), categoryString, true);

            var parts=new List<SparePart>();

            foreach (SparePart part in spareParts) 
            {
                if (part.Category == category) 
                {
                    parts.Add(part);
                }
            }

            foreach (SparePart part in parts) 
            {
                listBox1.Items.Add(part.Name);
                listBox1.Items.Add(part.BuyPrice);
                listBox1.Items.Add(part.Company.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Visible = true;
            string name=textBox2.Text;

            List<SparePart> parts=new List<SparePart>();

            foreach (SparePart part in spareParts) 
            {
                if (part.Name == name)
                {
                    parts.Add(part);
                }
            }

            foreach (SparePart part in parts)
            {
                listBox2.Items.Add(part.Name);
                listBox2.Items.Add(part.ClientPrice);
                listBox2.Items.Add("For cars:");

                foreach(var item in part.Cars)
                {
                    listBox2.Items.Add(item.Brand);
                    listBox2.Items.Add(item.Model);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Visible = true;
            string categoryString = textBox3.Text;
            Category category = (Category)Enum.Parse(typeof(Category), categoryString, true);

            decimal minPrice=decimal.Parse(textBox4.Text);
            decimal maxPrice=decimal.Parse(textBox5.Text);
            
            var parts=new List<SparePart>();

            foreach (SparePart part in spareParts)
            {
                if(part.Category == category && part.BuyPrice>=minPrice && part.BuyPrice <= maxPrice)
                {
                    parts.Add(part);
                }
            }

            foreach (var part in parts)
            {
                listBox3.Items.Add(part.Code);
                listBox3.Items.Add(part.Company.Name);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           string brand = textBox10.Text;
           string model = textBox11.Text;
           DateTime date = DateTime.Parse(textBox12.Text);

           cars.Add(new Car(brand, model, date));

            textBox10.Clear();  
            textBox11.Clear();
            textBox12.Clear();
        }
    }
}
