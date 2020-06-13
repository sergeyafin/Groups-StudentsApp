using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач
{
    public partial class AddGroupForm : Form
    {
        public Form1 form1;
        bool add = false;
        public AddGroupForm()
        {
            InitializeComponent();
        }

        private void AddGroupForm_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.lstG.Add(new Учебная_группа(textBox5.Text, int.Parse(textBox1.Text), comboBox1.Text, textBox2.Text, textBox4.Text));
            add = true;
            MessageBox.Show("Группа добавлена");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (add)
            {
                form1.учебнаягруппаBindingSource.ResetBindings(false);
            }
            Close();
        }
    }
}
