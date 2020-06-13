namespace Курсач
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._24_04_GroupStudentDataSet = new Курсач._24_04_GroupStudentDataSet();
            this.studentsTableAdapter = new Курсач._24_04_GroupStudentDataSetTableAdapters.StudentsTableAdapter();
            this.tableAdapterManager = new Курсач._24_04_GroupStudentDataSetTableAdapters.TableAdapterManager();
            this.студентDataGridView = new System.Windows.Forms.DataGridView();
            this.имя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.год = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рейтинг = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефон = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.студентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.студентBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._24_04_GroupStudentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(632, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(632, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Изменить студента";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(632, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Добавить студента";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(632, 191);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 47);
            this.button4.TabIndex = 2;
            this.button4.Text = "Удалить студента";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(242, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Студенты";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 130);
            this.panel1.TabIndex = 11;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.LightGray;
            this.radioButton3.Checked = global::Курсач.Properties.Settings.Default.rb1;
            this.radioButton3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Курсач.Properties.Settings.Default, "rb1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioButton3.Location = new System.Drawing.Point(297, 54);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(37, 17);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = ">=";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.LightGray;
            this.radioButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioButton2.Checked = global::Курсач.Properties.Settings.Default.rb2;
            this.radioButton2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Курсач.Properties.Settings.Default, "rb2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioButton2.Location = new System.Drawing.Point(349, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.Text = "<=";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.LightGray;
            this.radioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioButton1.Checked = global::Курсач.Properties.Settings.Default.rb3;
            this.radioButton1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Курсач.Properties.Settings.Default, "rb3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioButton1.Location = new System.Drawing.Point(398, 54);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.Text = "=";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(464, 84);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 33);
            this.button8.TabIndex = 14;
            this.button8.Text = "Показать всех";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(464, 43);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 33);
            this.button7.TabIndex = 14;
            this.button7.Text = "Убрать фильтр";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(464, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 32);
            this.button6.TabIndex = 14;
            this.button6.Text = "Фильтрация";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Год";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(259, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Как фильтровать по рейтингу:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Рейтинг";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Имя";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Курсач.Properties.Settings.Default, "tb4", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox4.Location = new System.Drawing.Point(326, 75);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 20);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = global::Курсач.Properties.Settings.Default.tb4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(109, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(221, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Фильтрация";
            // 
            // _24_04_GroupStudentDataSet
            // 
            this._24_04_GroupStudentDataSet.DataSetName = "_24_04_GroupStudentDataSet";
            this._24_04_GroupStudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GroupsTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Курсач._24_04_GroupStudentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // студентDataGridView
            // 
            this.студентDataGridView.AllowUserToAddRows = false;
            this.студентDataGridView.AllowUserToDeleteRows = false;
            this.студентDataGridView.AllowUserToOrderColumns = true;
            this.студентDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.студентDataGridView.AutoGenerateColumns = false;
            this.студентDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.студентDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.студентDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.имя,
            this.год,
            this.рейтинг,
            this.телефон,
            this.dataGridViewTextBoxColumn5});
            this.студентDataGridView.DataSource = this.студентBindingSource;
            this.студентDataGridView.Location = new System.Drawing.Point(42, 65);
            this.студентDataGridView.Name = "студентDataGridView";
            this.студентDataGridView.Size = new System.Drawing.Size(546, 220);
            this.студентDataGridView.TabIndex = 11;
            this.студентDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // имя
            // 
            this.имя.DataPropertyName = "Имя";
            this.имя.HeaderText = "Имя";
            this.имя.Name = "имя";
            this.имя.Width = 54;
            // 
            // год
            // 
            this.год.DataPropertyName = "Год";
            this.год.HeaderText = "Год";
            this.год.Name = "год";
            this.год.Width = 50;
            // 
            // рейтинг
            // 
            this.рейтинг.DataPropertyName = "Рейтинг";
            this.рейтинг.HeaderText = "Рейтинг";
            this.рейтинг.Name = "рейтинг";
            this.рейтинг.Width = 73;
            // 
            // телефон
            // 
            this.телефон.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.телефон.DataPropertyName = "Телефон";
            this.телефон.HeaderText = "Телефон";
            this.телефон.Name = "телефон";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 43;
            // 
            // студентBindingSource
            // 
            this.студентBindingSource.DataSource = typeof(Курсач.Студент);
            // 
            // студентBindingSource1
            // 
            this.студентBindingSource1.DataSource = typeof(Курсач.Студент);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 463);
            this.Controls.Add(this.студентDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._24_04_GroupStudentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.BindingSource студентBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label7;
        private _24_04_GroupStudentDataSet _24_04_GroupStudentDataSet;
        private _24_04_GroupStudentDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private _24_04_GroupStudentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView студентDataGridView;
        private System.Windows.Forms.BindingSource студентBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn имя;
        private System.Windows.Forms.DataGridViewTextBoxColumn год;
        private System.Windows.Forms.DataGridViewTextBoxColumn рейтинг;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефон;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}