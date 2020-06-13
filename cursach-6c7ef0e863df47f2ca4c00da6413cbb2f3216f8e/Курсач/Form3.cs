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
        public List<Студент> lst = new List<Студент>();
        public int n;

        public Form1 form1;
        bool add = false;

        public AddGroupForm()
        {
            InitializeComponent();
        }

        private void AddGroupForm_Load(object sender, EventArgs e)
        {
            студентBindingSource.DataSource = lst;

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
            Form1.lstG.Add(new Учебная_группа(textBox5.Text, год, comboBox1.Text, textBox2.Text, textBox4.Text, lst));
            add = true;
            _24_04_GroupStudentDataSet.GroupsRow row =_24_04_GroupStudentDataSet.Groups.NewGroupsRow();
            row.Gr_Name = textBox5.Text;
            row.Gr_Year = int.Parse(textBox1.Text);
            row.Gr_Faculty = comboBox1.Text;
            row.Gr_mail = textBox4.Text;
            row.Gr_Starosta = textBox2.Text;
            _24_04_GroupStudentDataSet.Groups.Rows.Add(row);
            MessageBox.Show("Группа добавлена");
            
            form1.учебнаягруппаBindingSource.ResetBindings(false);
            form1.Filter();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

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
                comboBox1.Text = "";
                lst.Clear();
                студентBindingSource.ResetBindings(false);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (add)
            {
                groupsBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(_24_04_GroupStudentDataSet);
                form1.учебнаягруппаBindingSource.ResetBindings(false);
            }
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddStudentForm formS = new AddStudentForm();

            formS.AddGroupForm = this;
            formS.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            n = dataGridView1.CurrentRow.Index;
            EditStudentForm formS = new EditStudentForm();

            formS.AddGroupForm = this;
            formS.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
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
    }
}
