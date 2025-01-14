using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgnProject
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string egn = textBox1.Text;
            
            EGNHuman egnHuman = new EGNHuman(egn);

            if (!egnHuman.IsValid())
            {
                label1.Text = "Невалидно ЕГН!";
                return;
            }

            string gender = egnHuman.GetGender();
            string birthDate = egnHuman.GetBirthDate();

            label1.Visible = true;

            label1.Text = $"Име: {name}" +
                $"\nЕГН: {egn}" +
                $"\nПол: {gender}" +
                $"\nДата на раждане: {birthDate}";

            }
        }
    }
