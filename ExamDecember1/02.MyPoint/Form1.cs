using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static _02.MyPoint.MyPoint;

namespace _02.MyPoint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);

            label3.Text = Kvadrant(x, y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);

            if (Bisector(x, y) == true)
            {
                label4.Text = "да, точката лежи на ъглополовящата";
            }
            else
            {
                label4.Text = "не, точката не лежи на ъглополовящата";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);

            label5.Text = Razstoqnie( x, y).ToString();
        }
    }
}
