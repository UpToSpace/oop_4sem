using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace laba2
{
    public partial class Form1 : Form
    {
        string path = "disciplines.json";

        public Form1()
        {
            InitializeComponent();
            courseComboBox.SelectedItem = courseComboBox.Items[0];
            cafedraComboBox1.SelectedItem = cafedraComboBox1.Items[0];
        }

        private bool Check()
        {
            if (
                !Regex.Match(classNumTextBox1.Text, @"^[0-9]+$").Success 
                    || !Regex.Match(fioTextBox1.Text, @"^[a-z]+$", RegexOptions.IgnoreCase).Success
                    || !Regex.Match(authorTextBox.Text, @"^[a-z]+$", RegexOptions.IgnoreCase).Success
                    || !Regex.Match(nameTextBox1.Text, @"^[a-z]+$", RegexOptions.IgnoreCase).Success
                    || semester1CheckBox.Checked == false && semester2CheckBox.Checked == false
                )
            {
                return false;
            }
            return true;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!Check())
            {
                MessageBox.Show("smth wrong","Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Discipline discipline = new Discipline();
            discipline.lector = new Lector();
            discipline.literature = new Literature();

            discipline.Name = nameTextBox.Text;
            discipline.Course = Convert.ToInt32(courseComboBox.SelectedItem);
            discipline.Speciality = Convert.ToString(specialityCheckedListBox.SelectedItem);
            discipline.Lections = Convert.ToInt32(lectionsTrackBar.Value);
            discipline.Labs = Convert.ToInt32(labsNumericUpDown.Value);
            discipline.Control = ekzamen.Checked ? ekzamen.Text : zachet.Text;

            discipline.Semester1 = semester1CheckBox.Checked.ToString();
            discipline.Semester2 = semester2CheckBox.Checked.ToString();

            discipline.lector.Cafedra = cafedraComboBox1.SelectedItem.ToString();

            discipline.lector.ClassNum = classNumTextBox1.Text;
            discipline.lector.Fio = fioTextBox1.Text;

            discipline.literature.Name = nameTextBox1.Text;
            discipline.literature.Author = authorTextBox.Text;
            discipline.literature.Year = Convert.ToInt32(yearDateTimePicker.Value.Year);



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

        private void show_Click(object sender, EventArgs e)
        {
            using (StreamReader sw = new StreamReader(path))
            {
                while (!sw.EndOfStream)
                {
                    listView1.Items.Add(JsonConvert.DeserializeObject<Discipline>(sw.ReadLine()).ToString());
                }
            }
        }

        private void lectionsTrackBar_Scroll(object sender, EventArgs e)
        {
            label1.Text = "current: " + Convert.ToString(lectionsTrackBar.Value);
        }
    }
}
