using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoservice
{
    public partial class Form1 : Form
    {
        AutoService autoService;
        public Form1()
        {
            InitializeComponent();
            autoService = new AutoService("Сервиз Гърми и Пуши");
            label7.Text = autoService.Name;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var path = "clients.txt";
            var lineToken = new List<string>();

            using (StreamReader sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    lineToken.Add(line);
                }
            }

            var names=new List<string>();

            foreach (string line in lineToken)
            {
                var splitted=line.Split(new string[] { "; " }, StringSplitOptions.RemoveEmptyEntries);
                names.Add(splitted[0]);
            }

            foreach (string line in lineToken)
            {
                listBox1.Items.Add(line);
            }

            foreach (string item in names)
            {
                comboBox1.Items.Add(item);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var path = "clients.txt";
            string name = textBox1.Text;
            string car=textBox2.Text;
            string problem=textBox3.Text;

            Client client = new Client(name, car, problem);

            autoService.AddClient(client);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            MessageBox.Show("Успешно добавихте клиент");

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine($"{client.Name}; {client.Automobile}; {client.Problem}");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name=comboBox1.SelectedItem.ToString();

            var client=autoService.FindClientByName(name);

            if (client != null) 
            {
                MessageBox.Show($"Автомобил: {client.Automobile} с проблем {client.Problem}");
            }
            else
            {
                MessageBox.Show("Не откриваме нищо...");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string problem = textBox4.Text;

            var found=autoService
                .FindClientsByProblem(problem)
                .ToList();

            if (found != null) 
            {
                foreach (var item in found) 
                {
                    listBox2.Items.Add(item.Automobile);
                }
            }
            else
            {
                MessageBox.Show("Не откриваме нищо...");

            }
        }
    }
}
