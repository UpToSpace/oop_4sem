
namespace laba2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label courseLabel;
            System.Windows.Forms.Label labsLabel;
            System.Windows.Forms.Label lectionsLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label semester1Label;
            System.Windows.Forms.Label semester2Label;
            System.Windows.Forms.Label specialityLabel;
            System.Windows.Forms.Label cafedraLabel1;
            System.Windows.Forms.Label classNumLabel1;
            System.Windows.Forms.Label fioLabel1;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label yearLabel;
            this.control = new System.Windows.Forms.GroupBox();
            this.zachet = new System.Windows.Forms.RadioButton();
            this.ekzamen = new System.Windows.Forms.RadioButton();
            this.save = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lectionsTrackBar = new System.Windows.Forms.TrackBar();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.semester1CheckBox = new System.Windows.Forms.CheckBox();
            this.semester2CheckBox = new System.Windows.Forms.CheckBox();
            this.specialityCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.literatureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafedraComboBox1 = new System.Windows.Forms.ComboBox();
            this.classNumTextBox1 = new System.Windows.Forms.TextBox();
            this.fioTextBox1 = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.yearDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            courseLabel = new System.Windows.Forms.Label();
            labsLabel = new System.Windows.Forms.Label();
            lectionsLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            semester1Label = new System.Windows.Forms.Label();
            semester2Label = new System.Windows.Forms.Label();
            specialityLabel = new System.Windows.Forms.Label();
            cafedraLabel1 = new System.Windows.Forms.Label();
            classNumLabel1 = new System.Windows.Forms.Label();
            fioLabel1 = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            this.control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectionsTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.literatureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // courseLabel
            // 
            courseLabel.AutoSize = true;
            courseLabel.Location = new System.Drawing.Point(23, 51);
            courseLabel.Name = "courseLabel";
            courseLabel.Size = new System.Drawing.Size(57, 17);
            courseLabel.TabIndex = 20;
            courseLabel.Text = "Course:";
            // 
            // labsLabel
            // 
            labsLabel.AutoSize = true;
            labsLabel.Location = new System.Drawing.Point(23, 79);
            labsLabel.Name = "labsLabel";
            labsLabel.Size = new System.Drawing.Size(43, 17);
            labsLabel.TabIndex = 22;
            labsLabel.Text = "Labs:";
            // 
            // lectionsLabel
            // 
            lectionsLabel.AutoSize = true;
            lectionsLabel.Location = new System.Drawing.Point(23, 131);
            lectionsLabel.Name = "lectionsLabel";
            lectionsLabel.Size = new System.Drawing.Size(65, 17);
            lectionsLabel.TabIndex = 24;
            lectionsLabel.Text = "Lections:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(23, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 26;
            nameLabel.Text = "Name:";
            // 
            // semester1Label
            // 
            semester1Label.AutoSize = true;
            semester1Label.Location = new System.Drawing.Point(23, 189);
            semester1Label.Name = "semester1Label";
            semester1Label.Size = new System.Drawing.Size(80, 17);
            semester1Label.TabIndex = 28;
            semester1Label.Text = "Semester1:";
            // 
            // semester2Label
            // 
            semester2Label.AutoSize = true;
            semester2Label.Location = new System.Drawing.Point(23, 219);
            semester2Label.Name = "semester2Label";
            semester2Label.Size = new System.Drawing.Size(80, 17);
            semester2Label.TabIndex = 30;
            semester2Label.Text = "Semester2:";
            // 
            // specialityLabel
            // 
            specialityLabel.AutoSize = true;
            specialityLabel.Location = new System.Drawing.Point(23, 244);
            specialityLabel.Name = "specialityLabel";
            specialityLabel.Size = new System.Drawing.Size(72, 17);
            specialityLabel.TabIndex = 32;
            specialityLabel.Text = "Speciality:";
            // 
            // cafedraLabel1
            // 
            cafedraLabel1.AutoSize = true;
            cafedraLabel1.Location = new System.Drawing.Point(285, 46);
            cafedraLabel1.Name = "cafedraLabel1";
            cafedraLabel1.Size = new System.Drawing.Size(62, 17);
            cafedraLabel1.TabIndex = 34;
            cafedraLabel1.Text = "Cafedra:";
            // 
            // classNumLabel1
            // 
            classNumLabel1.AutoSize = true;
            classNumLabel1.Location = new System.Drawing.Point(285, 77);
            classNumLabel1.Name = "classNumLabel1";
            classNumLabel1.Size = new System.Drawing.Size(79, 17);
            classNumLabel1.TabIndex = 36;
            classNumLabel1.Text = "Class Num:";
            // 
            // fioLabel1
            // 
            fioLabel1.AutoSize = true;
            fioLabel1.Location = new System.Drawing.Point(285, 105);
            fioLabel1.Name = "fioLabel1";
            fioLabel1.Size = new System.Drawing.Size(31, 17);
            fioLabel1.TabIndex = 38;
            fioLabel1.Text = "Fio:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(278, 189);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(54, 17);
            authorLabel.TabIndex = 39;
            authorLabel.Text = "Author:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(278, 217);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(49, 17);
            nameLabel1.TabIndex = 41;
            nameLabel1.Text = "Name:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(278, 246);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(42, 17);
            yearLabel.TabIndex = 43;
            yearLabel.Text = "Year:";
            // 
            // control
            // 
            this.control.Controls.Add(this.zachet);
            this.control.Controls.Add(this.ekzamen);
            this.control.Location = new System.Drawing.Point(26, 360);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(200, 73);
            this.control.TabIndex = 5;
            this.control.TabStop = false;
            this.control.Text = "control";
            // 
            // zachet
            // 
            this.zachet.AutoSize = true;
            this.zachet.Checked = true;
            this.zachet.Location = new System.Drawing.Point(7, 50);
            this.zachet.Name = "zachet";
            this.zachet.Size = new System.Drawing.Size(71, 21);
            this.zachet.TabIndex = 1;
            this.zachet.TabStop = true;
            this.zachet.Text = "zachet";
            this.zachet.UseVisualStyleBackColor = true;
            // 
            // ekzamen
            // 
            this.ekzamen.AutoSize = true;
            this.ekzamen.Location = new System.Drawing.Point(7, 21);
            this.ekzamen.Name = "ekzamen";
            this.ekzamen.Size = new System.Drawing.Size(86, 21);
            this.ekzamen.TabIndex = 0;
            this.ekzamen.Text = "ekzamen";
            this.ekzamen.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(255, 300);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(143, 102);
            this.save.TabIndex = 12;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(404, 300);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(134, 102);
            this.show.TabIndex = 13;
            this.show.Text = "show";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // courseComboBox
            // 
            this.courseComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.disciplineBindingSource, "Course", true));
            this.courseComboBox.DisplayMember = "1";
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.courseComboBox.Location = new System.Drawing.Point(109, 48);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(121, 24);
            this.courseComboBox.TabIndex = 21;
            // 
            // disciplineBindingSource
            // 
            this.disciplineBindingSource.DataSource = typeof(laba2.Discipline);
            // 
            // labsNumericUpDown
            // 
            this.labsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.disciplineBindingSource, "Labs", true));
            this.labsNumericUpDown.Location = new System.Drawing.Point(109, 79);
            this.labsNumericUpDown.Name = "labsNumericUpDown";
            this.labsNumericUpDown.Size = new System.Drawing.Size(121, 22);
            this.labsNumericUpDown.TabIndex = 23;
            // 
            // lectionsTrackBar
            // 
            this.lectionsTrackBar.LargeChange = 10;
            this.lectionsTrackBar.Location = new System.Drawing.Point(94, 131);
            this.lectionsTrackBar.Maximum = 100;
            this.lectionsTrackBar.Name = "lectionsTrackBar";
            this.lectionsTrackBar.Size = new System.Drawing.Size(170, 56);
            this.lectionsTrackBar.TabIndex = 25;
            this.lectionsTrackBar.TickFrequency = 10;
            this.lectionsTrackBar.Scroll += new System.EventHandler(this.lectionsTrackBar_Scroll);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplineBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(109, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 22);
            this.nameTextBox.TabIndex = 27;
            // 
            // semester1CheckBox
            // 
            this.semester1CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.disciplineBindingSource, "Semester1", true));
            this.semester1CheckBox.Location = new System.Drawing.Point(109, 184);
            this.semester1CheckBox.Name = "semester1CheckBox";
            this.semester1CheckBox.Size = new System.Drawing.Size(27, 24);
            this.semester1CheckBox.TabIndex = 29;
            this.semester1CheckBox.UseVisualStyleBackColor = true;
            // 
            // semester2CheckBox
            // 
            this.semester2CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.disciplineBindingSource, "Semester2", true));
            this.semester2CheckBox.Location = new System.Drawing.Point(109, 214);
            this.semester2CheckBox.Name = "semester2CheckBox";
            this.semester2CheckBox.Size = new System.Drawing.Size(27, 24);
            this.semester2CheckBox.TabIndex = 31;
            this.semester2CheckBox.UseVisualStyleBackColor = true;
            // 
            // specialityCheckedListBox
            // 
            this.specialityCheckedListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.disciplineBindingSource, "Speciality", true));
            this.specialityCheckedListBox.FormattingEnabled = true;
            this.specialityCheckedListBox.Items.AddRange(new object[] {
            "POIT",
            "ISIT",
            "DAIVY",
            "MOBILES"});
            this.specialityCheckedListBox.Location = new System.Drawing.Point(109, 244);
            this.specialityCheckedListBox.Name = "specialityCheckedListBox";
            this.specialityCheckedListBox.Size = new System.Drawing.Size(121, 89);
            this.specialityCheckedListBox.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "current: 0";
            // 
            // cafedraComboBox1
            // 
            this.cafedraComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplineBindingSource, "lector.Cafedra", true));
            this.cafedraComboBox1.FormattingEnabled = true;
            this.cafedraComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cafedraComboBox1.Location = new System.Drawing.Point(370, 43);
            this.cafedraComboBox1.Name = "cafedraComboBox1";
            this.cafedraComboBox1.Size = new System.Drawing.Size(150, 24);
            this.cafedraComboBox1.TabIndex = 35;
            // 
            // classNumTextBox1
            // 
            this.classNumTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplineBindingSource, "lector.ClassNum", true));
            this.classNumTextBox1.Location = new System.Drawing.Point(370, 74);
            this.classNumTextBox1.Name = "classNumTextBox1";
            this.classNumTextBox1.Size = new System.Drawing.Size(150, 22);
            this.classNumTextBox1.TabIndex = 37;
            // 
            // fioTextBox1
            // 
            this.fioTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplineBindingSource, "lector.Fio", true));
            this.fioTextBox1.Location = new System.Drawing.Point(370, 102);
            this.fioTextBox1.Name = "fioTextBox1";
            this.fioTextBox1.Size = new System.Drawing.Size(150, 22);
            this.fioTextBox1.TabIndex = 39;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplineBindingSource, "literature.Author", true));
            this.authorTextBox.Location = new System.Drawing.Point(338, 186);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(200, 22);
            this.authorTextBox.TabIndex = 40;
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplineBindingSource, "literature.Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(338, 214);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(200, 22);
            this.nameTextBox1.TabIndex = 42;
            // 
            // yearDateTimePicker
            // 
            this.yearDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.disciplineBindingSource, "literature.Year", true));
            this.yearDateTimePicker.Location = new System.Drawing.Point(338, 242);
            this.yearDateTimePicker.Name = "yearDateTimePicker";
            this.yearDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.yearDateTimePicker.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Prepod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "literature";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(544, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(610, 586);
            this.listView1.TabIndex = 48;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 593);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearDateTimePicker);
            this.Controls.Add(cafedraLabel1);
            this.Controls.Add(this.cafedraComboBox1);
            this.Controls.Add(classNumLabel1);
            this.Controls.Add(this.classNumTextBox1);
            this.Controls.Add(fioLabel1);
            this.Controls.Add(this.fioTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(courseLabel);
            this.Controls.Add(this.courseComboBox);
            this.Controls.Add(labsLabel);
            this.Controls.Add(this.labsNumericUpDown);
            this.Controls.Add(lectionsLabel);
            this.Controls.Add(this.lectionsTrackBar);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(semester1Label);
            this.Controls.Add(this.semester1CheckBox);
            this.Controls.Add(semester2Label);
            this.Controls.Add(this.semester2CheckBox);
            this.Controls.Add(specialityLabel);
            this.Controls.Add(this.specialityCheckedListBox);
            this.Controls.Add(this.show);
            this.Controls.Add(this.save);
            this.Controls.Add(this.control);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.control.ResumeLayout(false);
            this.control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectionsTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.literatureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox control;
        private System.Windows.Forms.RadioButton zachet;
        private System.Windows.Forms.RadioButton ekzamen;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.BindingSource disciplineBindingSource;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.NumericUpDown labsNumericUpDown;
        private System.Windows.Forms.TrackBar lectionsTrackBar;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.CheckBox semester1CheckBox;
        private System.Windows.Forms.CheckBox semester2CheckBox;
        private System.Windows.Forms.CheckedListBox specialityCheckedListBox;
        private System.Windows.Forms.BindingSource lectorBindingSource;
        private System.Windows.Forms.BindingSource literatureBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cafedraComboBox1;
        private System.Windows.Forms.TextBox classNumTextBox1;
        private System.Windows.Forms.TextBox fioTextBox1;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.DateTimePicker yearDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
    }
}

