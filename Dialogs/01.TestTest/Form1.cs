using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _01.TestTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult openResult = openFileDialog1.ShowDialog();

            try
            {
                using (StreamReader streamReader = new StreamReader(openFileDialog1.FileName))
                {
                    if (openResult == DialogResult.OK)
                    {
                        richTextBox1.Text = streamReader.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult saveResult=saveFileDialog1.ShowDialog();

            try
            {
                using (StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName))
                {
                   if (saveResult == DialogResult.OK)
                   {
                      streamWriter.Write(richTextBox1.Text);
                   }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formatFullToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Trim();
        }

        private void formatTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Replace("  ", " ");
        }

        private void colorBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (ColorDialog colorDialog = new ColorDialog())
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.BackColor = colorDialog.Color;
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void colorFullToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (ColorDialog colorDialog = new ColorDialog())
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.ForeColor = colorDialog.Color;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void colorTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (ColorDialog colorDialog = new ColorDialog())
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.SelectionColor = colorDialog.Color;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
