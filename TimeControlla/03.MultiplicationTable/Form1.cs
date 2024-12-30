using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace _03.MultiplicationTable
{
    public partial class Form1 : Form
    {
        private int timeLeft;
        private System.Timers.Timer timer;
        private double answer = 0;
        public Form1()
        {
            InitializeComponent();
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += timer1_Tick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeLeft = 15; 
            timer.Start();
            GenerateQuestion();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                UpdateTimerLabel();
            }
            else
            {
                timer.Stop();
                label1.Text = "Времето приключи!";
            }
        }

        private void UpdateTimerLabel()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateTimerLabel));
            }
            else
            {
                label2.Text = $"Оставащо време: {timeLeft} секунди";
            }
        }

        private void GenerateQuestion()
        {
            Random rand = new Random();
            int num1 = rand.Next(1, 10);
            int num2 = rand.Next(1, 10);
            label3.Text = $"{num1} x {num2} = ?";
            answer = num1 * num2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double currAnswer = double.Parse(textBox1.Text);

            if (currAnswer == answer) 
            {
                MessageBox.Show("Верен отговор! Натисни бутона Start за още въпроси!");
            }
            else
            {
                MessageBox.Show("Пробвай пак или си преговори таблицата лешпер!");
            }
        }
    }
}
