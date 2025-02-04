using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01.Children_sRoom
{
    public partial class Form1 : Form
    {
        private List<Teacher> teachers;
        private List<Child> children;
        private List<Group> groups;
        public Form1()
        {
            InitializeComponent();
            teachers = new List<Teacher>();
            children = new List<Child>();
            groups = new List<Group>();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GroupType groupType = new GroupType();

            string groupTypeString= comboBox1.SelectedItem.ToString();
            if (groupTypeString== "Млад художник")
            {
                groupType = GroupType.МХ;
            }
            else if (groupTypeString== "Изкуството в действие")
            {
                groupType = GroupType.ИВД;
            }
            else if (groupTypeString == "Млад програмист")
            {
                groupType = GroupType.МП;
            }
            else if (groupTypeString == "Аз програмирам игрите си")
            {
                groupType = GroupType.АПИ;
            }
            else if (groupTypeString == "Роботика")
            {
                groupType = GroupType.Р;
            }
            else if (groupTypeString == "Музиката е моя живот")
            {
                groupType = GroupType.ММЖ;
            }

            string day = comboBox2.SelectedItem.ToString();
            string hour = comboBox3.SelectedItem.ToString();
            string minutes = comboBox4.SelectedItem.ToString();
            string groupTime = hour + ":" + minutes;

            var group = new Group(groupType, day, groupTime);
            groups.Add(group);

            if (group.Day == "Понеделник")
            {
                label19.Text = label19.Text + $"{groupTypeString} е в {groupTime}" + "\n";
            }
            else if (group.Day == "Вторник")
            {
                label20.Text = label20.Text + $"{groupTypeString} е в {groupTime}" + "\n";
            }
            else if (group.Day == "Сряда")
            {
                label21.Text = label21.Text + $"{groupTypeString} е в {groupTime}" + "\n";
            }
            else if (group.Day == "Четвъртък")
            {
                label22.Text = label22.Text + $"{groupTypeString} е в {groupTime}" + "\n";
            }
            else if (group.Day == "Петък")
            {
                label23.Text = label23.Text + $"{groupTypeString} е в {groupTime}" + "\n";
            }

            MessageBox.Show("Групата е добавена успешно!");

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name=textBox1.Text;
            string specialty = textBox2.Text;
            var teacher = new Teacher(name, specialty);
            var groups=textBox3.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var group in groups)
            {
                var groupType = (GroupType)Enum.Parse(typeof(GroupType), group.ToUpper());
                teacher.Groups.Add(new Group(groupType, "", ""));
            }
            teachers.Add(teacher);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            MessageBox.Show("Преподавателят е добавен успешно!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name= textBox4.Text;
            int age = int.Parse(textBox5.Text);
            var child = new Child(name, age);
            var groups = textBox6.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var group in groups)
            {
                var groupType = (GroupType)Enum.Parse(typeof(GroupType), group);
                child.Groups.Add(new Group(groupType, "", ""));
            }
            children.Add(child);

            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            MessageBox.Show("Детето е добавено успешно!");
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
/* МХ,
    ИВД,
    МП,
    АПИ,
    Р,
    ММЖ
*/