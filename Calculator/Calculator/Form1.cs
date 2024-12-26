using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double sum, plusMinus, multiS, devS, subS, plusS,currN;
        private char symbol = ' ';
       
        public Form1()
        {
            InitializeComponent();       
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            sum = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
           currN =double.Parse(textBox1.Text)*(-1);
            textBox1.Text = currN.ToString();          
        }
        private void button3_Click(object sender, EventArgs e)
        {
            currN = double.Parse(textBox1.Text) / 100;
            textBox1.Text = currN.ToString();  
        }
        private void button4_Click(object sender, EventArgs e)
        {
            symbol = '/';
            devS=double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button16.Text;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button11.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button13.Text;
        }


        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button14.Text;
        }


        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button15.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button17.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            symbol = '*';
            sum=double.Parse(textBox1.Text);
            textBox1.Clear();
        }


        private void button12_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
