using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomPicture
{
    public partial class Form1 : Form
    {
        PictureBox[] images = new PictureBox[6];
        public Form1()
        {
            InitializeComponent();

            images[0] = pictureBox1;
            images[1] = pictureBox2;
            images[2] = pictureBox3;
            images[3] = pictureBox4;
            images[4] = pictureBox5;
            images[5] = pictureBox6;

            Random r = new Random();

            int index = r.Next(0, 5);

            pictureBox7.Image = images[index].Image;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = -1;
            for (int i = 0; i < images.Length; i++) 
            {
                if(images[i].Image == pictureBox7.Image)
                {
                    index = i;
                    break;
                }
            }

            if (index == 0)
            {
                pictureBox7.Image = images[images.Length-1].Image;
            }
            else
            {
                pictureBox7.Image = images[index - 1].Image;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = -1;
            for (int i = 0; i < images.Length; i++)
            {
                if (images[i].Image == pictureBox7.Image)
                {
                    index = i;
                    break;
                }
            }

            if (index == images.Length - 1) 
            {
                pictureBox7.Image = images[0].Image;
            }
            else
            {
                pictureBox7.Image= images[index+1].Image;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
