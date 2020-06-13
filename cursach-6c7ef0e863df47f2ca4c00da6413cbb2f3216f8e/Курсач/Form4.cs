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
    public partial class AddStudentForm : Form
    {
        public AddGroupForm AddGroupForm;
        public EditGroupForm EditGroupForm;
        public Form2 Form2;
        bool add = false;
        bool egf = false;
        bool agf = false;
        bool f2 = false;
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int год;
            int рейтинг;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Не задано имя");
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Не задан телефон");
                textBox4.Focus();
                return;
            }
            if (!int.TryParse(textBox2.Text, out год))
            {
                MessageBox.Show("Год должен быть задан числом");
                textBox2.Focus();
                return;
            }
            if (!int.TryParse(textBox5.Text, out рейтинг))
            {
                MessageBox.Show("Рейтинг должен быть задан числом");
                textBox5.Focus();
                return;
            }
            if (agf)
            {
                AddGroupForm.lst.Add(new Студент(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox5.Text), textBox4.Text));
                add = true;
                AddGroupForm.студентBindingSource.ResetBindings(false);
            }
            if (egf)
            {EditGroupForm.lst.Add(new Студент(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox5.Text), textBox4.Text));
            add = true;
            EditGroupForm.студентBindingSource.ResetBindings(false); }
            if (f2)
            {
                Form2.lst.Add(new Студент(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox5.Text), textBox4.Text));
                add = true;
                Form2.студентBindingSource.ResetBindings(false);
                Form2.Filter();
            }
            
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "AddGroupForm")
                    agf = true;
                if (f.Name == "EditGroupForm")
                    egf = true;
                if (f.Name == "Form2")
                    f2 = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                         "Вы действительно хотите очистить все поля?", "Внимание",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textBox5.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (add)
            {
                if (agf)
                    AddGroupForm.студентBindingSource.ResetBindings(false);
                if (egf)
                    EditGroupForm.студентBindingSource.ResetBindings(false);
                if (f2)
                {
                    Form2.студентBindingSource.ResetBindings(false);
                    Form2.Filter();
                        }

            }
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
