using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using laba2.Memento;
// TODO Добавить строку состояния с тестовыми сообщениями последнем выполненном действии.Добавить 
// возможность скрывать и закреплять панель инструментов.

namespace laba2
{
    public partial class Form1 : Form
    {
        string path = "disciplines.json";
        List<Discipline> disciplines = new List<Discipline>();
        string searchParameter = "", lastAction = "";
        History history = new History();
        public Form1()
        {
            InitializeComponent();
            
            Settings.GetSettings(this);
            lastAction = "Form opened";
            courseComboBox.SelectedItem = courseComboBox.Items[0];
            cafedraComboBox1.SelectedItem = cafedraComboBox1.Items[0];

            Timer timer = new Timer() { Interval = 1000 };
            timer.Start();
            timer.Tick += Tick;
        }
        
        private void Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            toolStripStatusLabel2.Text = "Objects number: " + Convert.ToString(dataGridView1.Rows.Count - 1);
            toolStripStatusLabel3.Text = lastAction;
        }
        private bool Check()
        {
            if (
                   !Regex.Match(classNumTextBox1.Text, @"^[0-9]+$").Success 
                || !Regex.Match(fioTextBox1.Text, @"^[a-z\s]+$", RegexOptions.IgnoreCase).Success
                || !Regex.Match(authorTextBox.Text, @"^[a-z\s]+$", RegexOptions.IgnoreCase).Success
                || !Regex.Match(nameTextBox1.Text, @"^[a-z\s]+$", RegexOptions.IgnoreCase).Success
                || semester1CheckBox.Checked == false && semester2CheckBox.Checked == false
                )
            {
                return false;
            }
            return true;
        }
        private void Clear()
        {
            nameTextBox.Clear();
            courseComboBox.SelectedItem = courseComboBox.Items[0];
            cafedraComboBox1.SelectedItem = cafedraComboBox1.Items[0];
            specialityCheckedListBox.ClearSelected();
            lectionsTrackBar.Value = 0;
            labsNumericUpDown.Value = 0;
            semester1CheckBox.Checked = false;
            semester2CheckBox.Checked = false;
            classNumTextBox1.Clear();
            fioTextBox1.Clear();
            nameTextBox1.Clear();
            authorTextBox.Clear();
            lastAction = "form cleared";
        }
        private Discipline Build(DisciplineBuilder disciplineBuilder)
        {
            disciplineBuilder.CreateDiscipline();
            disciplineBuilder.SetFields(nameTextBox.Text, Convert.ToInt32(courseComboBox.SelectedItem), Convert.ToString(specialityCheckedListBox.SelectedItem),
                Convert.ToInt32(lectionsTrackBar.Value), Convert.ToInt32(labsNumericUpDown.Value), semester1CheckBox.Checked.ToString(),
                semester2CheckBox.Checked.ToString(), ekzamen.Checked ? ekzamen.Text : zachet.Text);
            disciplineBuilder.SetLector(cafedraComboBox1.SelectedItem.ToString(), fioTextBox1.Text, classNumTextBox1.Text);
            disciplineBuilder.SetLiterature(nameTextBox1.Text, authorTextBox.Text, Convert.ToInt32(yearDateTimePicker.Value.Year));
            return disciplineBuilder.Discipline;
        }
        private void save_Click(object sender, EventArgs e)
        {
            lastAction = "button saved clicked";
            if (!Check())
            {
                MessageBox.Show("smth wrong","Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DisciplineBuilder disciplineBuilder = new ITDisciplineBuilder();
            Discipline discipline = Build(disciplineBuilder);

            if (discipline != null)
            {
                ValidationContext contex = new ValidationContext(discipline, null, null);
                List<ValidationResult> errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(discipline, contex, errors, true))
                {
                    foreach (var item in errors)
                    {
                        MessageBox.Show(item.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

            }
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(JsonConvert.SerializeObject(discipline));
            }
        }
        private void Add(Discipline discipline)
        {
            disciplines.Add(discipline);
            var i = discipline.ShowRow();
            dataGridView1.Rows.Add(i.Item1, i.Item2, i.Item3, i.Item4, i.Item5, i.Item6, i.Item7, i.Item8, i.Item9, i.Item10, i.Item11, i.Item12, i.Item13);
        }
        private void show_Click(object sender, EventArgs e)
        {
            lastAction = "button show clicked";
            history.FormHistory.Push(SaveState());
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            using (StreamReader sw = new StreamReader(path))
            {
                while (!sw.EndOfStream)
                {
                    Discipline discipline = JsonConvert.DeserializeObject<Discipline>(sw.ReadLine());
                    Add(discipline);
                }

                Discipline disciplineClone = disciplines[0].Clone() as Discipline; // clone
                Add(disciplineClone);

                Discipline discipline1 = new Discipline(); // abstract factory
                discipline1.Lector = discipline1.CreateLector() as Lector;
                discipline1.Literature = discipline1.CreateLiterature() as Literature;
                //Add(discipline1);

                Discipline decorator = new Decorator.Decorator(disciplines[0]); // decorator
                Add(decorator);
            }
        }
        public Mori SaveState()
        {
            return new Mori(ref disciplines);
        }
        public void RestoreState(Mori state)
        {
            disciplines = state.disciplines;
        }
        private void lectionsTrackBar_Scroll(object sender, EventArgs e)
        {
            label1.Text = "current: " + Convert.ToString(lectionsTrackBar.Value);
        }
        private void Search(object sender)
        {
            history.FormHistory.Push(SaveState());
            textBox1.Show();
            label4.Show();
            searchParameter = sender.ToString();
            switch (searchParameter)
            {
                case "lector":
                    label4.Text = "Enter lector's name";
                    break;
                case "semester":
                    label4.Text = "Enter semester number";
                    break;
                case "course":
                    label4.Text = "Enter course number";
                    break;
                default:
                    break;
            }
        }

        public void Sort(object sender)
        {
            history.FormHistory.Push(SaveState());
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            IEnumerable<Discipline> list = new List<Discipline>();
            switch (sender.ToString())
            {
                case "lection numbers":
                    list = disciplines.OrderBy(ev => ev.Lections);
                    break;
                case "control":
                    list = disciplines.OrderBy(ev => ev.Control);
                    break;
                default:
                    break;
            }
            foreach (var item in list)
            {
                var i = item.ShowRow();
                dataGridView1.Rows.Add(i.Item1, i.Item2, i.Item3, i.Item4, i.Item5, i.Item6, i.Item7, i.Item8, i.Item9, i.Item10, i.Item11, i.Item12, i.Item13);
            }
        }
        private void lectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search(sender);
        }

        private void semesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search(sender);
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search(sender);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            List<Discipline> list = new List<Discipline>();
            switch (searchParameter)
            {
                case "lector":
                    list = disciplines.Where(ev => ev.Lector.Fio.Contains(textBox1.Text)).ToList();
                    break;
                case "semester":
                    list = disciplines.Where(ev => ev.str.Contains(textBox1.Text)).ToList();
                    break;
                case "course":
                    list = disciplines.Where(ev => Convert.ToString(ev.Course).Contains(textBox1.Text)).ToList();
                    break;
                default:
                    break;
            }
            foreach (var item in list)
            {
                var i = item.ShowRow();
                dataGridView1.Rows.Add(i.Item1, i.Item2, i.Item3, i.Item4, i.Item5, i.Item6, i.Item7, i.Item8, i.Item9, i.Item10, i.Item11, i.Item12, i.Item13);
            }
        }

        private void lectionNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sort(sender);
        }

        private void controlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastAction = sender.ToString();
            Sort(sender);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author is Me!!!!", "EXTRAIMPORTANT MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string savePath = "result.json";
            using (StreamWriter sw = new StreamWriter(savePath, true))
            {
                for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
                {
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        sw.Write(JsonConvert.SerializeObject(dataGridView1.Rows[j].Cells[i].Value) + "\t");
                    }
                    sw.WriteLine();
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            object obj = "lection numbers";
            Sort(obj);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            object obj = "control";
            Sort(obj);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            object obj = "lector";
            Search(obj);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            object obj = "semester";
            Search(obj);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            object obj = "course";
            Search(obj);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            try
            {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            RestoreState(history.FormHistory.Pop());
            foreach (Discipline discipline in disciplines)
            {
                var i = discipline.ShowRow();
                dataGridView1.Rows.Add(i.Item1, i.Item2, i.Item3, i.Item4, i.Item5, i.Item6, i.Item7, i.Item8, i.Item9, i.Item10, i.Item11, i.Item12, i.Item13);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
