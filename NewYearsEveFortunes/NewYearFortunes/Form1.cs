using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewYearFortunes
{
    public partial class Form1 : Form
    {

        Dictionary<byte, string> fortunes = new Dictionary<byte, string>();
        int count = 0;

        public Form1()
        {
            InitializeComponent();

            fortunes.Add(1, "Купони предстоят ти щури с отлежало уиски и хавански пури");
            fortunes.Add(2, "През таз година ще си имаш бебче, пухкаво и бяло – като хлебче!");
            fortunes.Add(3, "Късметът на теб се пада, ще си облечен в дрехи на Прада!");
            fortunes.Add(4, "Няма вече да вървиш пеша, пада ти се нова кола.");
            fortunes.Add(5, "Ще те гали морски бриз на интерконтинентален круиз");
            fortunes.Add(6, "В игра джакпота ще уцелиш и крупна сума ще спечелиш.");
            fortunes.Add(7, "На далеч ще летиш и Дубай ще посетиш.");
            fortunes.Add(8, "Ще е празник за душата, любов ще ти завърти главата!");
            fortunes.Add(9, "Мотиката в килера остави, меринджей ще ставаш ти!");
            fortunes.Add(10, "Ще си здрав/а като шкаф от соца");
            fortunes.Add(11, "Пачки по стотачки");
            fortunes.Add(12, "Бурни нощи в дискотека – ей това ти е късмета");
            fortunes.Add(13, "Хич не ти е до учение. Пада ти се ПРИКЛЮЧЕНИЕ.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FortunesCanBeDublicates();


        }

        private void UniqueFortunes()
        {
            Random r = new Random();
            int index = r.Next(1, 13);
            label1.Visible = true;
            pictureBox1.Visible = true;

            string fortune = fortunes[(byte)index];
            count++;


        }

        private void FortunesCanBeDublicates()
        {
            Random r = new Random();
            int index = r.Next(1, 13);
            label1.Visible = true;
            pictureBox1.Visible = true;

            switch (index)
            {
                case 1:
                    label1.Text = fortunes[1];
                    pictureBox1.Image = Image.FromFile("уиски.jpg");
                    break;

                case 2:
                    label1.Text = fortunes[2];
                    pictureBox1.Image = Image.FromFile("бебе.jpg");
                    break;
                case 3:
                    label1.Text = fortunes[3];
                    pictureBox1.Image = Image.FromFile("prada.jpg");
                    break;
                case 4:
                    label1.Text = fortunes[4];
                    pictureBox1.Image = Image.FromFile("kola.jpg");
                    break;
                case 5:
                    label1.Text = fortunes[5];
                    pictureBox1.Image = Image.FromFile("cruise.jpg");
                    break;
                case 6:
                    label1.Text = fortunes[6];
                    pictureBox1.Image = Image.FromFile("casino.jpg");
                    break;
                case 7:
                    label1.Text = fortunes[7];
                    pictureBox1.Image = Image.FromFile("dubai.jpg");
                    break;
                case 8:
                    label1.Text = fortunes[8];
                    pictureBox1.Image = Image.FromFile("love.jpg");
                    break;
                case 9:
                    label1.Text = fortunes[9];
                    pictureBox1.Image = Image.FromFile("manager.jpg");
                    break;
                case 10:
                    label1.Text = fortunes[10];
                    pictureBox1.Image = Image.FromFile("cult.jpg");
                    break;
                case 11:
                    label1.Text = fortunes[11];
                    pictureBox1.Image = Image.FromFile("money.jpg");
                    break;
                case 12:
                    label1.Text = fortunes[12];
                    pictureBox1.Image = Image.FromFile("club.jpg");
                    break;
                case 13:
                    label1.Text = fortunes[13];
                    pictureBox1.Image = Image.FromFile("exp.jpg");
                    break;
            }
        }
    }
}
