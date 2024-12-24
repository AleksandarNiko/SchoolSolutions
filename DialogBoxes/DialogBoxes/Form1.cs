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

namespace DialogBoxes
{
    public partial class Form1 : Form
    {
        double number = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r=MessageBox.Show("Искате ли да изчислите квадратен корен на число?"
                ,""
                ,MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (r == DialogResult.No)
            {
                MessageBox.Show("Ok, няма да изчисляваме нищо!");
                Application.Exit();
            }
            else
            {
                DialogResult res = InputPositiveNumber();

                if (res == DialogResult.OK)
                {
                    MessageBox.Show($"{Math.Sqrt(number)}");
                    DialogResult rsl = MessageBox.Show("Искате ли да извършите ново изчисление?"
                , ""
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (rsl == DialogResult.Yes) 
                    {

                    }
                }
                else
                {
                    DialogResult result = InputPositiveNumber();
                }
            }
        }

        private DialogResult InputPositiveNumber()
        {
            number = double.Parse(Interaction.InputBox("Въведете положително число!",
                "Въвеждане на положително число"));
            DialogResult res = MessageBox.Show("Сигурни ли сте, че искате да изчислите квадратен корен на това число"
                , ""
                , MessageBoxButtons.OKCancel);
            return res;
        }
    }
}
