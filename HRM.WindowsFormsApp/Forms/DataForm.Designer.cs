namespace TestTask.WindowsFormsApp
{
    partial class DataForm
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
            this.peopleDataGridView = new System.Windows.Forms.DataGridView();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEmploy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateUneploy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.depComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.postComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearFilterbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statisticDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.unEmployRadioButton = new System.Windows.Forms.RadioButton();
            this.employRadioButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statisticEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statisticStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.statisticStatusComboBox = new System.Windows.Forms.ComboBox();
            this.enterStatisticButton = new System.Windows.Forms.Button();
            this.updateDataButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // peopleDataGridView
            // 
            this.peopleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.peopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peopleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO,
            this.DateEmploy,
            this.DateUneploy,
            this.Status,
            this.Dep,
            this.Post});
            this.peopleDataGridView.Location = new System.Drawing.Point(20, 29);
            this.peopleDataGridView.Name = "peopleDataGridView";
            this.peopleDataGridView.ReadOnly = true;
            this.peopleDataGridView.Size = new System.Drawing.Size(898, 250);
            this.peopleDataGridView.TabIndex = 0;
            this.peopleDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PeopleDataGridView_CellClick);
            this.peopleDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.PeopleDataGridView_CellFormatting);
            // 
            // FIO
            // 
            this.FIO.DataPropertyName = "FIO";
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            this.FIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // DateEmploy
            // 
            this.DateEmploy.DataPropertyName = "DateEmploy";
            this.DateEmploy.HeaderText = "Дата приема";
            this.DateEmploy.Name = "DateEmploy";
            this.DateEmploy.ReadOnly = true;
            this.DateEmploy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // DateUneploy
            // 
            this.DateUneploy.DataPropertyName = "DateUneploy";
            this.DateUneploy.HeaderText = "Дата увольнения";
            this.DateUneploy.Name = "DateUneploy";
            this.DateUneploy.ReadOnly = true;
            this.DateUneploy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Dep
            // 
            this.Dep.DataPropertyName = "Dep";
            this.Dep.HeaderText = "Отдел";
            this.Dep.Name = "Dep";
            this.Dep.ReadOnly = true;
            this.Dep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Post
            // 
            this.Post.DataPropertyName = "Post";
            this.Post.HeaderText = "Должность";
            this.Post.Name = "Post";
            this.Post.ReadOnly = true;
            this.Post.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameTextBox.Location = new System.Drawing.Point(31, 65);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(152, 26);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // filterButton
            // 
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterButton.Location = new System.Drawing.Point(16, 194);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(158, 33);
            this.filterButton.TabIndex = 3;
            this.filterButton.Text = "Отфильтровать";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // depComboBox
            // 
            this.depComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.depComboBox.FormattingEnabled = true;
            this.depComboBox.Location = new System.Drawing.Point(34, 130);
            this.depComboBox.Name = "depComboBox";
            this.depComboBox.Size = new System.Drawing.Size(149, 28);
            this.depComboBox.TabIndex = 4;
            // 
            // statusComboBox
            // 
            this.statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(214, 63);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(149, 28);
            this.statusComboBox.TabIndex = 5;
            // 
            // postComboBox
            // 
            this.postComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.postComboBox.FormattingEnabled = true;
            this.postComboBox.Location = new System.Drawing.Point(214, 130);
            this.postComboBox.Name = "postComboBox";
            this.postComboBox.Size = new System.Drawing.Size(149, 28);
            this.postComboBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearFilterbutton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.statusComboBox);
            this.groupBox1.Controls.Add(this.postComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lastNameTextBox);
            this.groupBox1.Controls.Add(this.depComboBox);
            this.groupBox1.Controls.Add(this.filterButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(936, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 250);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтрация";
            // 
            // clearFilterbutton
            // 
            this.clearFilterbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearFilterbutton.Location = new System.Drawing.Point(200, 194);
            this.clearFilterbutton.Name = "clearFilterbutton";
            this.clearFilterbutton.Size = new System.Drawing.Size(187, 33);
            this.clearFilterbutton.TabIndex = 10;
            this.clearFilterbutton.Text = "Сбросить фильтр";
            this.clearFilterbutton.UseVisualStyleBackColor = true;
            this.clearFilterbutton.Click += new System.EventHandler(this.ClearFilterbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(210, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Должность:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отдел:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(210, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Статус:";
            // 
            // statisticDataGridView
            // 
            this.statisticDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.statisticDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.statisticDataGridView.Location = new System.Drawing.Point(34, 25);
            this.statisticDataGridView.Name = "statisticDataGridView";
            this.statisticDataGridView.ReadOnly = true;
            this.statisticDataGridView.Size = new System.Drawing.Size(247, 250);
            this.statisticDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn1.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.unEmployRadioButton);
            this.groupBox2.Controls.Add(this.employRadioButton);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.statisticEndDateTimePicker);
            this.groupBox2.Controls.Add(this.statisticStartDateTimePicker);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.statisticStatusComboBox);
            this.groupBox2.Controls.Add(this.enterStatisticButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(338, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 250);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Статистика";
            // 
            // unEmployRadioButton
            // 
            this.unEmployRadioButton.AutoSize = true;
            this.unEmployRadioButton.Location = new System.Drawing.Point(22, 156);
            this.unEmployRadioButton.Name = "unEmployRadioButton";
            this.unEmployRadioButton.Size = new System.Drawing.Size(195, 28);
            this.unEmployRadioButton.TabIndex = 13;
            this.unEmployRadioButton.TabStop = true;
            this.unEmployRadioButton.Text = "Уволен с работы";
            this.unEmployRadioButton.UseVisualStyleBackColor = true;
            // 
            // employRadioButton
            // 
            this.employRadioButton.AutoSize = true;
            this.employRadioButton.Location = new System.Drawing.Point(22, 120);
            this.employRadioButton.Name = "employRadioButton";
            this.employRadioButton.Size = new System.Drawing.Size(203, 28);
            this.employRadioButton.TabIndex = 12;
            this.employRadioButton.TabStop = true;
            this.employRadioButton.Text = "Принят на работу";
            this.employRadioButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(392, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Конечная дата:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(212, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Начальная дата:";
            // 
            // statisticEndDateTimePicker
            // 
            this.statisticEndDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statisticEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.statisticEndDateTimePicker.Location = new System.Drawing.Point(396, 77);
            this.statisticEndDateTimePicker.Name = "statisticEndDateTimePicker";
            this.statisticEndDateTimePicker.Size = new System.Drawing.Size(149, 26);
            this.statisticEndDateTimePicker.TabIndex = 9;
            // 
            // statisticStartDateTimePicker
            // 
            this.statisticStartDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statisticStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.statisticStartDateTimePicker.Location = new System.Drawing.Point(216, 77);
            this.statisticStartDateTimePicker.Name = "statisticStartDateTimePicker";
            this.statisticStartDateTimePicker.Size = new System.Drawing.Size(149, 26);
            this.statisticStartDateTimePicker.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(18, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Статус:";
            // 
            // statisticStatusComboBox
            // 
            this.statisticStatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.statisticStatusComboBox.FormattingEnabled = true;
            this.statisticStatusComboBox.Location = new System.Drawing.Point(22, 75);
            this.statisticStatusComboBox.Name = "statisticStatusComboBox";
            this.statisticStatusComboBox.Size = new System.Drawing.Size(149, 28);
            this.statisticStatusComboBox.TabIndex = 5;
            // 
            // enterStatisticButton
            // 
            this.enterStatisticButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterStatisticButton.Location = new System.Drawing.Point(387, 192);
            this.enterStatisticButton.Name = "enterStatisticButton";
            this.enterStatisticButton.Size = new System.Drawing.Size(158, 33);
            this.enterStatisticButton.TabIndex = 3;
            this.enterStatisticButton.Text = "Вывести";
            this.enterStatisticButton.UseVisualStyleBackColor = true;
            this.enterStatisticButton.Click += new System.EventHandler(this.EnterStatisticButton_Click);
            // 
            // updateDataButton
            // 
            this.updateDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateDataButton.Location = new System.Drawing.Point(20, 291);
            this.updateDataButton.Name = "updateDataButton";
            this.updateDataButton.Size = new System.Drawing.Size(211, 33);
            this.updateDataButton.TabIndex = 10;
            this.updateDataButton.Text = "Обновить данные";
            this.updateDataButton.UseVisualStyleBackColor = true;
            this.updateDataButton.Click += new System.EventHandler(this.UpdateDataButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Location = new System.Drawing.Point(633, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(27, 22);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(677, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Уволенные сотрудники";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1372, 426);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.peopleDataGridView);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.updateDataButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1364, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.statisticDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1364, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Статистика";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 447);
            this.Controls.Add(this.tabControl1);
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.Load += new System.EventHandler(this.DataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView peopleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEmploy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateUneploy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.ComboBox depComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ComboBox postComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearFilterbutton;
        private System.Windows.Forms.DataGridView statisticDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker statisticEndDateTimePicker;
        private System.Windows.Forms.DateTimePicker statisticStartDateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox statisticStatusComboBox;
        private System.Windows.Forms.Button enterStatisticButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton unEmployRadioButton;
        private System.Windows.Forms.RadioButton employRadioButton;
        private System.Windows.Forms.Button updateDataButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}