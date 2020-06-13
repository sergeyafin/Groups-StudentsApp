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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static List<Учебная_группа> lstG = new List<Учебная_группа>();
        int rowAdd;
        public int n;
        int sort_order=-1;
        bool first_sort = true;
        int current_column=50;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            rowAdd = dataGridView1.RowCount;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "GroupDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this._24_04_GroupStudentDataSet.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_24_04_GroupStudentDataSet.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this._24_04_GroupStudentDataSet.Groups);
            
            
            foreach (DataRow rg in _24_04_GroupStudentDataSet.Groups.Rows)
            {
                List<Студент> lst = new List<Студент>();
                
                foreach (DataRow rs in _24_04_GroupStudentDataSet.Students.Rows)
                {
                    
                    if ((int)rs["Group_ID"] == (int)rg["Group_ID"])
                    {
                        lst.Add(new Студент(rs["St_Name"].ToString(), Convert.ToInt32(rs["St_Year"]), Convert.ToInt32(rs["St_Rating"]), rs["St_Phone_Number"].ToString()));
                        
                    }
                    
                    
                }
                lstG.Add(new Учебная_группа(rg["Gr_Name"].ToString(), (int)rg["Gr_Year"], rg["Gr_Faculty"].ToString(), rg["Gr_Starosta"].ToString(), rg["Gr_mail"].ToString(), lst));
                          
            }
            учебнаягруппаBindingSource.DataSource = lstG;

            //ExtendDGV extendDGV=new ExtendDGV()
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            n = dataGridView1.CurrentRow.Index;

            Form2 formS = new Form2();
            formS.lst = lstG[n].Студенты;


            formS.ShowDialog();
            учебнаягруппаBindingSource.ResetCurrentItem();
            Filter();
              
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AddGroupForm formS = new AddGroupForm();
            formS.form1 = this;
            formS.ShowDialog();
            Filter();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            n = dataGridView1.CurrentRow.Index;
            EditGroupForm formS = new EditGroupForm();
            formS.lst = lstG[n].Студенты;
            formS.form1 = this;
            formS.ShowDialog();
            учебнаягруппаBindingSource.ResetCurrentItem();
            Filter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id;
            if (dataGridView1.CurrentCell == null)
                return;
            if (dataGridView1.SelectedRows.Count>1)
            {
                if (MessageBox.Show(
                    "Вы действительно хотите удалить несколько групп?", "Внимание",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    List<Учебная_группа> listDel = new List<Учебная_группа>();

                    foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                    {
                        id = (int)r.Cells["groupid"].Value;
                        listDel.Add(lstG[r.Index]);
                        _24_04_GroupStudentDataSet.Groups.FindByGroup_ID(id).Delete();

                    }
                    foreach (Учебная_группа item in listDel)
                        lstG.Remove(item);
                    _24_04_GroupStudentDataSet.Students.AcceptChanges();
                    учебнаягруппаBindingSource.ResetBindings(false);
                    Filter();
                    return;
                }
                else
                    return;
            }
            id = (int)dataGridView1.CurrentRow.Cells["groupid"].Value;
            if (MessageBox.Show(
                    "Вы действительно хотите удалить группу ?", "Внимание",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            lstG.RemoveAt(dataGridView1.CurrentRow.Index);
            _24_04_GroupStudentDataSet.Groups.FindByGroup_ID(id).Delete();
            _24_04_GroupStudentDataSet.Students.AcceptChanges();
            учебнаягруппаBindingSource.ResetBindings(false);
            Filter();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            groupsBindingSource.EndEdit();
            studentsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(_24_04_GroupStudentDataSet);
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Filter();
        }
        public void Filter()
        {
            dataGridView1.CurrentCell = null;
            for (int i = 0; i < dataGridView1.Rows.Count - rowAdd; i++)
            {
                if (TestRow(i))
                    dataGridView1.Rows[i].Visible = true;
                else
                    dataGridView1.Rows[i].Visible = false;
                
            }
        }
        private bool TestRow(int i)
        {
            if (textBox1.Text != "" && lstG[i].Название.ToUpper().StartsWith(textBox1.Text.ToUpper()) == false) return false;

            if (textBox2.Text != "" && lstG[i].Год.ToString().ToUpper().StartsWith(textBox2.Text.ToUpper()) == false) return false;

            if (textBox3.Text != "" && lstG[i].Староста.ToUpper().StartsWith(textBox3.Text.ToUpper()) == false) return false;

            if (textBox4.Text != "" && lstG[i].Почта.ToUpper().StartsWith(textBox4.Text.ToUpper()) == false) return false;

            if (comboBox2.Text != "" && lstG[i].Факультет.ToUpper().StartsWith(comboBox2.Text.ToUpper()) == false) return false;

            return true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox2.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].Visible = true;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > rowAdd)
            {
                //если нажали на столбец не в первый раз подряд, нужно стереть добавление стрелочки в прошлый раз
                if (current_column == e.ColumnIndex)
                    dataGridView1.Columns[e.ColumnIndex].HeaderText = dataGridView1.Columns[e.ColumnIndex].HeaderText.Substring(0, dataGridView1.Columns[e.ColumnIndex].HeaderText.Length - 1);
                //если нажали на другой столбец или нажали в первый раз
                if (current_column != e.ColumnIndex)
                {
                    sort_order = -1;
                    //если нажали на другой столбец, надо стереть изменения в предыдущем столбце
                    if (!first_sort)
                        dataGridView1.Columns[current_column].HeaderText = dataGridView1.Columns[current_column].HeaderText.Substring(0, dataGridView1.Columns[current_column].HeaderText.Length - 1);
                    //если нажали в первый раз, стирать ничего не надо
                    else
                        first_sort = false;

                    current_column = e.ColumnIndex;
                }


                sort_order = -1 * sort_order;
                //sort_order = -1 - по убыванию
                //sort_order = 1 - по возрастанию

                if (sort_order == 1)
                    dataGridView1.Columns[e.ColumnIndex].HeaderText = dataGridView1.Columns[e.ColumnIndex].HeaderText + "↓";
                if (sort_order == -1)
                    dataGridView1.Columns[e.ColumnIndex].HeaderText = dataGridView1.Columns[e.ColumnIndex].HeaderText + "↑";

                switch (dataGridView1.Columns[e.ColumnIndex].Name)
                {
                    case "название":
                        lstG.Sort(delegate (Учебная_группа a1, Учебная_группа a2)
                        {
                            return sort_order * a1.Название.CompareTo(a2.Название);
                        });
                        break;
                    case "год":
                        lstG.Sort(delegate (Учебная_группа a1, Учебная_группа a2)
                        {
                            return sort_order * a1.Год.CompareTo(a2.Год);
                        });
                        
                        break;
                    case "факультет":
                        if (sort_order == 1)
                            lstG = lstG.OrderBy(Учебная_группа => Учебная_группа.Факультет).ToList();
                        if (sort_order == -1)
                            lstG = lstG.OrderByDescending(Учебная_группа => Учебная_группа.Факультет).ToList();
                        учебнаягруппаBindingSource.DataSource = lstG;
                        Filter();
                        break;
                    case "староста":
                        lstG.Sort(delegate (Учебная_группа a1, Учебная_группа a2)
                        {
                            return sort_order * a1.Староста.CompareTo(a2.Староста);
                        });
                        
                        break;
                    case "почта":
                        if (sort_order==1)
                            lstG = lstG.OrderBy(Учебная_группа => Учебная_группа.Почта).ToList();
                        if (sort_order == -1)
                            lstG = lstG.OrderByDescending(Учебная_группа => Учебная_группа.Почта).ToList();
                        учебнаягруппаBindingSource.DataSource = lstG;
                        Filter();
                        break;
                    default:
                        Filter();
                        return;
                        
                }
                Filter();

            }
        }

        
    }
    public class Учебная_группа
    {

        public int Год { get; set; }
        public string Староста { get; set; }
        public string Почта { get; set; }
        public string Название { get; set; }
        public string Факультет { get; set; }
        public int ID { get; set; }

        static int id_now = 1;
        public List<Студент> Студенты { get; set; }
        public void Список_группы()
        {
            Console.WriteLine("Список группы " + Название + ":");
            foreach (Студент s in Студенты)
                Console.WriteLine(s);
        }
        public Учебная_группа(string название, int год, string факультет, string староста, string почта, List<Студент> студенты)
        {

            Год = год;
            Староста = староста;
            Факультет = факультет;
            Почта = почта;
            Название = название;
            Студенты = студенты;
            ID = id_now;
            id_now = id_now + 1;

        }
        public Учебная_группа(string название, int год, string факультет, string староста, string почта)
        {

            Год = год;
            Староста = староста;
            Факультет = факультет;
            Почта = почта;
            Название = название;
            List<Студент> lst = new List<Студент>();
            Студенты = lst;
            ID = id_now;
            id_now = id_now + 1;

        }
        public override string ToString()
        {
            return string.Format("Группа {3}, год набора {0}, " +
                "староста {1}, почта {2}", Год, Староста, Почта, Название);
        }

        public int Количество_студентов()
        {
            int Количество = Студенты.Count();
            return Количество;


        }
        public double Средний_рейтинг()
        {
            double rate = 0;
            foreach (Студент st in Студенты)
                rate = rate + st.Рейтинг;
            return rate / Студенты.Count();

        }

    }
    //----------------------------------------------------------------------------------------------------------------------
    public class Студент
    {

        public int Год { get; set; }
        public int Рейтинг { get; set; }
        public string Телефон { get; set; }
        public string Имя { get; set; }
        public int ID { get; set; }

        static int id_now = 1;

        public Студент(string имя, int год, int рейтинг, string телефон)
        {

            Год = год;
            Рейтинг = рейтинг;
            Телефон = телефон;
            Имя = имя;
            ID = id_now;
            id_now = id_now + 1;
        }

        public override string ToString()
        {
            return string.Format("Студент {3}, год рождения {0}, " +
                "рейтинг {1}, телефон {2}", Год, Рейтинг, Телефон, Имя);



        }

    }
}

