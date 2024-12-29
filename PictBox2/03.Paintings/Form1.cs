using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03.Paintings
{
    public partial class Form1 : Form
    {
        Painting[] paintings=new Painting[10];
        public Form1()
        {
            InitializeComponent();

            paintings[0] = new Painting()
            {
                AuthorName = "Vincent van Gogh",
                PaintingName = "Starry Night",
                Picture=
            };

            paintings[1] = new Painting()
            {
                AuthorName = " Pablo Picasso",
                PaintingName = "Guernica",
                Picture =
            };

            paintings[2] = new Painting()
            {
                AuthorName = "  Claude Monet",
                PaintingName = "Water Lilies",
                Picture =
            };

            paintings[3] = new Painting()
            {
                AuthorName = "Frida Kahlo",
                PaintingName = "The Two Fridas",
                Picture =
            };

            paintings[4] = new Painting()
            {
                AuthorName = "Leonardo da Vinci",
                PaintingName = "Mona Lisa",
                Picture =
            };

            paintings[5] = new Painting()
            {
                AuthorName = " Jackson Pollock",
                PaintingName = "No. 5, 1948",
                Picture =
            };

            paintings[6] = new Painting()
            {
                AuthorName = " Georgia O'Keeffe",
                PaintingName = "Black Iris III",
                Picture =
            };
            paintings[7] = new Painting()
            {
                AuthorName = " Salvador Dalí",
                PaintingName = "The Persistence of Memory",
                Picture =
            };

            paintings[8] = new Painting()
            {
                AuthorName = " Henri Matisse",
                PaintingName = "The Dance",
                Picture =
            };

            paintings[9] = new Painting()
            {
                AuthorName = " Andy Warhol",
                PaintingName = "",
                Picture =
            };

            paintings[10] = new Painting()
            {
                AuthorName = " Pablo Picasso",
                PaintingName = "Guernica",
                Picture =
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
