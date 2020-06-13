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
        List<string> lstGroupName = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Студент> lst = new List<Студент>();
            lst.Add(new Студент("Иванов", 2000, 60, "+7 (927) 159-25-89"));
            lst.Add(new Студент("Иванова", 2000, 50, "+7 (965) 023-77-51"));
            lst.Add(new Студент("Иванбек", 2001, 87, "+7 (941) 103-88-41"));
            lst.Add(new Студент("Иванка", 2000, 30, "+7 (927) 163-23-79"));
            lst.Add(new Студент("Иванидзе", 2000, 99, "+7 (927) 193-12-51"));
            lst.Add(new Студент("Иванчик", 2001, 1, "+7 (979) 128-91-12"));
            lst.Add(new Студент("Ивуля", 2000, 50, "+7 (922) 121-88-11"));
            lst.Add(new Студент("Ивлев", 2000, 61, "+7 (911) 122-05-91"));
            lst.Add(new Студент("Ивашка", 2001, 79, "+7 (999) 678-10-44"));
            lst.Add(new Студент("Иванов", 2000, 37, "+7 (912) 342-44-36"));


            lstG.Add(new Учебная_группа("ПИ18-3", 2018, "Факультет анализа рисков и экономической безопасности имени профессора В.К.Сенчагова", lst[2].Имя, "PI18-3@edu.fa.ru", lst));

            lst = new List<Студент>();
            lst.Add(new Студент("Красоткина", 2000, 70, "+7 (923) 701-49-36"));
            lst.Add(new Студент("Красотина", 2000, 89, "+7 (97) 5 43-35-78"));
            lst.Add(new Студент("Красулина", 2001, 97, "+7 (969) 123-05-77"));
            lst.Add(new Студент("Краска", 2000, 78, "+7 (911) 729-98-05"));
            lst.Add(new Студент("Красотуля", 2000, 59, "+7 (935) 916-23-78"));
            lst.Add(new Студент("Краснюк", 2001, 50, "+7 (970) 429-11-78"));


            lstG.Add(new Учебная_группа("ПИ18-4", 2018, "Юридический факультет", lst[3].Имя, "PI18-4@edu.fa.ru", lst));

            lst = new List<Студент>();
            lst.Add(new Студент("Николашкин", 2000, 70, "+7 (923) 701-49-36"));
            lst.Add(new Студент("Никиткин", 2000, 89, "+7 (97) 5 43-35-78"));
            lst.Add(new Студент("Никин", 2001, 97, "+7 (969) 123-05-77"));
            lst.Add(new Студент("Ник", 2000, 78, "+7 (911) 729-98-05"));
            lst.Add(new Студент("Николидзе", 2000, 59, "+7 (935) 916-23-78"));
            lst.Add(new Студент("Николятор", 2001, 50, "+7 (970) 429-11-78"));

            lstG.Add(new Учебная_группа("ПИ19-5", 2019, "Факультет менеджмента", lst[5].Имя, "PI19-5@edu.fa.ru", lst));

            учебнаягруппаBindingSource.DataSource = lstG;
            
            //ExtendDGV extendDGV=new ExtendDGV()
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index == dataGridView1.RowCount - 1)
                return;
            int n = dataGridView1.CurrentRow.Index;
            Form2 formS = new Form2();
            formS.студентBindingSource.DataSource = lstG[n].Студенты;
            formS.Show();
            учебнаягруппаBindingSource.ResetCurrentItem();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void учебнаягруппаBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGroupForm formS = new AddGroupForm();
            formS.form1 = this;
            formS.ShowDialog();
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

