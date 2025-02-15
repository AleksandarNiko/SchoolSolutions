﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static _01.MyNumber.MyNumber;

namespace _01.MyNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number=int.Parse(textBox1.Text);
            
            label2.Text = ProstoLie(number).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);

            label3.Text = Obratno(number).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);

            var nums=ProstiDeliteli(number);

            foreach (var num in nums) 
            {
                listBox1.Items.Add(num);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);

            label4.Text = IsEven(number);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);

            label5.Text = IsPolindrom(number);
        }
    }
}
