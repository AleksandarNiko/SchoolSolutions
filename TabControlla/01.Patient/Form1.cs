using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01.Patient
{
    public partial class Form1 : Form
    {
        List<Patient> patients = new List<Patient>();
        private const decimal pricePerDay = 8.90M;
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name=textBox1.Text;
            byte age=byte.Parse(textBox2.Text);
            string diagnose=textBox3.Text;
            int days=int.Parse(comboBox1.Text);

            patients.Add(new Patient(name, age, diagnose, days));

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            label5.Visible = true;
            label5.Text = "Успешно добавихте пациент!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string currentName=textBox4.Text;

            List<Patient> foundPatients = new List<Patient>();

            foreach (Patient pat in patients)
            {
                if (pat.Name.Contains (currentName))
                {
                    foundPatients.Add(pat);
                }
            }

            if (foundPatients.Count != 0)
            {
                foreach (Patient pat in foundPatients)
                {
                    listBox1.Items.Add($"{pat.ToString()} дължи {pat.PriceToPay(pricePerDay)}lv.");
                }
            }
            else
            {
                listBox1.Items.Add("Няма намерени пациенти!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string diagnose=textBox5.Text.ToLower();

            List<Patient> foundPatients = new List<Patient>();

            foreach (Patient pat in patients) 
            {
                if (pat.Diagnose == diagnose) 
                {
                    foundPatients.Add(pat);
                }
            }

            if (!foundPatients.Any())
            {
                listBox2.Items.Add("Няма намерени пациенти!");
            }
            else
            {
                foreach (var item in foundPatients)
                {
                    listBox2.Items.Add(item.ToString());
                }
            }
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            byte age = byte.Parse(textBox6.Text);

            List<Patient> foundPats=new List<Patient>();

            foreach (Patient pat in patients) 
            {
                if (pat.Age == age) 
                {
                    foundPats.Add(pat);
                }
            }

            if (!foundPats.Any()) 
            {
                listBox3.Items.Add("Няма намерени пациенти!");
            }
            else
            {
                foreach (var item in foundPats)
                {
                    listBox3.Items.Add(item.ToString());
                }
            }
        }
    }
}
