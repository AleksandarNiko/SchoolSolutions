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

namespace Converter
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while (true)
            {
                DialogResult r = MessageBox.Show("Искате ли да конвертирате валута?"
                    , "Избор"
                    , MessageBoxButtons.YesNo);

                if (r == DialogResult.Yes)
                {
                    DialogResult r2 = MessageBox.Show("Натисни ОК за USD->EUR и CANCEL за EUR->USD"
                        , ""
                        , MessageBoxButtons.OKCancel);
                    if (r2 == DialogResult.OK) 
                    {
                        CurrencyConverter currencyConverter = new CurrencyConverter();
                        double amount = double.Parse(Interaction.InputBox($"Моля въведете " +
                            $"стойността на ДОЛАРИТЕ за конвертиране{"\n"} към" +
                            $"EURO", "Въвеждане на числова стойност"));

                        MessageBox.Show($"{currencyConverter.ConvertUsdToEur(amount)}EUR");

                        DialogResult res=MessageBox.Show("Искате ли да нааправите ново конвертиране"
                            ,""
                            ,MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                        {

                        }
                    }
                    else
                    {
                        CurrencyConverter currencyConverter = new CurrencyConverter();
                        double amount = double.Parse(Interaction.InputBox($"Моля въведете " +
                            $"стойността на ДОЛАРИТЕ за конвертиране{"\n"} към" +
                            $"EURO", "Въвеждане на числова стойност"));

                        MessageBox.Show($"{currencyConverter.ConvertEurToUsd(amount)}USD");
                    }
                }
            }
        }
    }
}
