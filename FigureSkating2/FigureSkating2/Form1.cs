using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureSkating2
{
    public partial class Form1 : Form
    {
        Dictionary <string,double> skaterPoints=new Dictionary<string, double> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                string name = Interaction.InputBox("Въведи име на състезателя.");
                skaterPoints.Add(name, 0); 
            }

            foreach (string name in skaterPoints.Keys)
            {
                listBox1.Items.Add($"Player added: {name}");
            }

            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                string info = Interaction.InputBox("Въведи име и точки за състезателя.");
                string[] lineToken = info.Split(' ');
                string name = lineToken[0];
                double points = double.Parse(lineToken[1]);

                if (skaterPoints.ContainsKey(name) && (points>0&&points<=10))
                {
                    skaterPoints[name] += points;
                }
                else
                {
                    label2.Text = $"Invalid name or points (1-10).";
                }
            }

            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in skaterPoints.OrderByDescending(p=>p.Value))
            {
                listBox2.Items.Add($"Player {item.Key} with Points {item.Value}");
            }

            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var winner = skaterPoints.OrderByDescending(x => x.Value)
                .First();

            label1.Text = $"Победител: {winner.Key} с {winner.Value} точки";

            button4.Visible = false;
        }
    }
}
