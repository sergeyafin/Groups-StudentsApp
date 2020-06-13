using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Курсач
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int n;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "GroupDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.GroupStudentDataSet.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_24_04_GroupStudentDataSet.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.GroupStudentDataSet.Groups);


            //ExtendDGV extendDGV=new ExtendDGV()
        }     
    
        private void button1_Click(object sender, EventArgs e)
        {
            studentsBindingSource.EndEdit();
            groupsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(GroupStudentDataSet);
            Close();
        }
        int idF;
        //----------------------------------------------------------
        private void pageStudent_Enter(object sender, EventArgs e)
        {
            idF = (int)groupsDataGridView.CurrentRow.Cells[0].Value;
            label1.Text = "Группа:   " +(string)groupsDataGridView.CurrentRow.Cells[1].Value;

            label2.Text = label1.Text;
            label3.Text = label1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=24.04 GroupStudent.mdb;";
            OleDbConnection connection = new OleDbConnection(connectString); //объявляем новый объект подключения

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = string.Format("insert into Students (St_Name, St_Year, St_Rating, St_Phone_Number, Group_ID) values ('{0}', {1}, {2}, '{3}',{4});", textBox1.Text, short.Parse(textBox2.Text), short.Parse(textBox3.Text), textBox4.Text, idF);
            command.ExecuteNonQuery(); //исполнение запроса                                                                                        
            connection.Close(); //закрытие подключения                                                                                             
                                                                                                                                                   
             

            //GroupStudentDataSet.Students.Rows.Add(row);
            //studentsBindingSource.EndEdit();
            //studentsTableAdapter.Update(GroupStudentDataSet.Students);

            // Уберем отрицательные значения счетчиков
            studentsTableAdapter.Fill(GroupStudentDataSet.Students);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabControl2.TabPages["pageList"];
        }
        _24_04_GroupStudentDataSet.StudentsRow row;

        private void button5_Click(object sender, EventArgs e)
        {
            row.St_Name = textBox8.Text;
            row.St_Year = short.Parse(textBox7.Text);
            row.St_Rating=short.Parse(textBox6.Text);
            row.St_Phone_Number = textBox5.Text;
            row.Group_ID= short.Parse(textBox15.Text);
            studentsBindingSource.EndEdit();
            studentsTableAdapter.Update(GroupStudentDataSet.Students);

            tabControl2.SelectedTab = tabControl2.TabPages["pageList"];
        }

        private void pageEdit_Enter(object sender, EventArgs e)
        {
            int ids = (int)studentsDataGridView.CurrentRow.Cells[0].Value;
            row = GroupStudentDataSet.Students.FindByStudent_ID(ids);
            textBox8.Text = row.St_Name;
            textBox7.Text = row.St_Year.ToString();
            textBox6.Text = row.St_Rating.ToString();
            textBox5.Text = row.St_Phone_Number;
            textBox15.Text = row.Group_ID.ToString();

        }
        


        private void groupsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (groupsDataGridView.Columns[e.ColumnIndex].Name == "id")
                MessageBox.Show("Возможно задан недопустимый номер группы.");
        }

        private void button6_Click(object sender, EventArgs e)//фильтрация
        {
            int rating = 0;
            if (textBox9.Text != "")
                if (!int.TryParse(textBox9.Text, out rating))
                {
                    MessageBox.Show("Рейтинг должен быть задан числом");
                    textBox9.Focus();
                    return;
                }

            if (radioButton1.Checked && textBox9.Text!="")
            {

                var filter1 =
                from student in GroupStudentDataSet.Students
                where student.St_Rating > rating
                select new
                {
                    Name = student.St_Name,
                    Rating = student.St_Rating
                };
                BindingSource1.DataSource = filter1.ToList();
                dataGridView1.DataSource = BindingSource1;
            }
            else if (radioButton2.Checked && textBox9.Text != "")
            {

                var filter1 =
                from student in GroupStudentDataSet.Students
                where student.St_Rating < rating
                select new
                {
                    Name = student.St_Name,
                    Rating = student.St_Rating
                };
                BindingSource1.DataSource = filter1.ToList();
                dataGridView1.DataSource = BindingSource1;
            }
            else if (radioButton3.Checked && textBox9.Text != "")
            {

                var filter1 =
                from student in GroupStudentDataSet.Students
                where student.St_Rating == rating
                select new
                {
                    Name = student.St_Name,
                    Rating = student.St_Rating
                };
                BindingSource1.DataSource = filter1.ToList();
                dataGridView1.DataSource = BindingSource1;
            }
            else
            {

                var filter1 =
                from student in GroupStudentDataSet.Students
                where student.St_Rating > rating
                select new
                {
                    Name= student.St_Name,
                    Rating = student.St_Rating
                };
                BindingSource1.DataSource = filter1.ToList();
                dataGridView1.DataSource = BindingSource1;
            }


        }

        private void dataGridView1_ColumnDisplayIndexChanged(object sender, DataGridViewColumnEventArgs e)
        {
            //MessageBox.Show(e.Column.Index.ToString() + "  " + e.Column.Name);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=24.04 GroupStudent.mdb;";
            OleDbConnection connection = new OleDbConnection(connectString); //объявляем новый объект подключения

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = string.Format("insert into Groups (Gr_Name, Gr_Year, Gr_Faculty, Gr_Starosta, Gr_mail) values ('{0}', {1}, '{2}', '{3}','{4}');", textBox10.Text, short.Parse(textBox11.Text), textBox12.Text, textBox13.Text, textBox14.Text);
            command.ExecuteNonQuery(); //исполнение запроса                                                                                        
            connection.Close(); //закрытие подключения                                                                                             



            //GroupStudentDataSet.Students.Rows.Add(row);
            //studentsBindingSource.EndEdit();
            //studentsTableAdapter.Update(GroupStudentDataSet.Students);

            // Уберем отрицательные значения счетчиков
            groupsTableAdapter.Fill(GroupStudentDataSet.Groups);
        }

        private void groupsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox10.Text = groupsDataGridView.CurrentRow.Cells["name"].Value.ToString();
            textBox11.Text = groupsDataGridView.CurrentRow.Cells["year"].Value.ToString();
            textBox12.Text = groupsDataGridView.CurrentRow.Cells["faculty"].Value.ToString();
            textBox13.Text = groupsDataGridView.CurrentRow.Cells["starosta"].Value.ToString();
            textBox14.Text = groupsDataGridView.CurrentRow.Cells["mail"].Value.ToString();
        }
        _24_04_GroupStudentDataSet.GroupsRow rowg;
        private void button8_Click(object sender, EventArgs e)
        {
            int ids = (int)groupsDataGridView.CurrentRow.Cells[0].Value;
            rowg = GroupStudentDataSet.Groups.FindByGroup_ID(ids);
            rowg.Gr_Name = textBox10.Text;
            rowg.Gr_Year = short.Parse(textBox11.Text);
            rowg.Gr_Faculty = textBox12.Text;
            rowg.Gr_Starosta = textBox13.Text;
            rowg.Gr_mail = textBox14.Text;
            groupsBindingSource.EndEdit();
            groupsTableAdapter.Update(GroupStudentDataSet.Groups);
        }

        private void groupsDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            tableAdapterManager.UpdateAll(GroupStudentDataSet);
            groupsTableAdapter.Fill(GroupStudentDataSet.Groups);
        }

        private void studentsDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            tableAdapterManager.UpdateAll(GroupStudentDataSet);
            studentsTableAdapter.Fill(GroupStudentDataSet.Students);
        }

        
    }
    
}

