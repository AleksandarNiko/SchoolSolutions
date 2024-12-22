using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int iterationCount = 0;
        private const int MaxIterations = 12;
        private List<string> messages;
        private Random random;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateFortunes();
        }

        private void GenerateFortunes()
        {

            int index = random.Next(messages.Count);
            string selectedMessage = messages[index];

            MessageBox.Show(selectedMessage, "Отворихте Подарък");

            messages.RemoveAt(index);

            iterationCount++;

            if (iterationCount >= MaxIterations)
            {
                MessageBox.Show("Всичко е отворено!", "Край!");
                Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {           

            messages = new List<string>
            {
                "Късмет",
                "Щастие",
                "Любов",
                "Радост",
                "Здраве",
                "Успех",
                "Подарък",
                "Изненада",
                "Мир",
                "Обич",
                "Хармония",
                "Благополучие"
            };

            random = new Random();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }
    }
}
