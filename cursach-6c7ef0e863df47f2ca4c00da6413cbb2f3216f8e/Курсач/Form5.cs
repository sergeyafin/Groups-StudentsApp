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
    public partial class EditGroupForm : Form

    {
        public Form1 form1;
        int i;
        public int n;
        bool add = false;
        public List<Студент> lst = new List<Студент>();
        public EditGroupForm()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            i = form1.n;
            textBox1.Text = (Form1.lstG[i].Год).ToString();
            textBox2.Text = (Form1.lstG[i].Староста);
            textBox4.Text = (Form1.lstG[i].Почта);
            textBox5.Text = (Form1.lstG[i].Название);
            comboBox1.Text = (Form1.lstG[i].Факультет);
            студентBindingSource.DataSource = lst;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int год;
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Не введено название группы");
                textBox5.Focus();
                return;
            }

            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Не выбран факультет");
                comboBox1.Focus();
                return;
            }

            if (!int.TryParse(textBox1.Text, out год))
            {
                MessageBox.Show("Год должен быть задан числом");
                textBox1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Не задан староста");
                textBox2.Focus();
                return;
            }

            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Не задана почта группы");
                textBox4.Focus();
                return;
            }
            Form1.lstG[i].Год=год;
            Form1.lstG[i].Староста=textBox2.Text ;
            Form1.lstG[i].Почта=textBox4.Text;
            Form1.lstG[i].Название=textBox5.Text;
            Form1.lstG[i].Факультет=comboBox1.Text;
            form1.учебнаягруппаBindingSource.ResetItem(i);
            form1.Filter();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            n = dataGridView1.CurrentRow.Index;
            EditStudentForm formS = new EditStudentForm();

            formS.EditGroupForm = this;
            formS.ShowDialog();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
                return;
            if (dataGridView1.SelectedRows.Count > 1)
            {
                if (MessageBox.Show(
                    "Вы действительно хотите удалить несколько студентов?", "Внимание",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    List<Студент> listDel = new List<Студент>();
                    foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                        listDel.Add(lst[item.Index]);
                    foreach (Студент item in listDel)
                        lst.Remove(item);
                    студентBindingSource.ResetBindings(false);
                    return;
                }
                else
                    return;
            }
            string stname = (string)dataGridView1.CurrentRow.Cells["имяDataGridViewTextBoxColumn"].Value;
            if (MessageBox.Show(
                    "Вы действительно хотите удалить студента " + stname + " ?", "Внимание",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            lst.RemoveAt(dataGridView1.CurrentRow.Index);
            студентBindingSource.ResetBindings(false);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddStudentForm formS = new AddStudentForm();

            formS.EditGroupForm = this;
            formS.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
