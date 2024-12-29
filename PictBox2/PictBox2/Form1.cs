using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = pictureBox10.Image;
            pictureBox10.Image = pictureBox1.Image;
            pictureBox1.Image = pictureBox2.Image;
            pictureBox2.Image = pictureBox3.Image;
            pictureBox3.Image = pictureBox4.Image;
            pictureBox4.Image = pictureBox5.Image;
            pictureBox5.Image = pictureBox6.Image;
            pictureBox6.Image = pictureBox7.Image;
            pictureBox7.Image = pictureBox8.Image;
            pictureBox8.Image = pictureBox9.Image;
            pictureBox9.Image = pictureBox10.Image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = pictureBox10.Image;
            pictureBox10.Image = pictureBox9.Image;
            pictureBox9.Image = pictureBox8.Image;
            pictureBox8.Image = pictureBox7.Image;
            pictureBox7.Image = pictureBox6.Image;
            pictureBox6.Image = pictureBox5.Image;
            pictureBox5.Image = pictureBox4.Image;
            pictureBox4.Image = pictureBox3.Image;
            pictureBox3.Image = pictureBox2.Image;
            pictureBox2.Image = pictureBox1.Image;
            pictureBox1.Image = pictureBox11.Image;
        }
    }
}
