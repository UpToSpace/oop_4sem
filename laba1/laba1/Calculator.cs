using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace laba1
{
    public partial class Calculator : Form, ICalculator
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            Hide();
            switch (comboBox1.Text)
            {
                case "Замена подстроки на другую подстроку":
                    label3.Text = "Введите что хотите заменить";
                    ShowDop();
                    ShowDop1();
                    break;
                case "Удаление заданных подстрок (символов)":
                    label3.Text = "Введите подстроку для удаления";
                    ShowDop();
                    break;
                case "Получение символа по индексу":
                    label3.Text = "Введите индекс буквы";
                    ShowDop();
                    break;
                default:
                    Hide();
                    break;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void count_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string dop = textBox2.Text;
            string dop1 = textBox4.Text;
            switch (comboBox1.Text)
            {
                case "Замена подстроки на другую подстроку":
                    ChangeSubstring(text, dop, dop1);
                    break;
                case "Удаление заданных подстрок (символов)": 
                    DeleteSymbols(text, dop);
                    break;
                case "Получение символа по индексу": 
                    CharByIndex(text, dop);
                    break;
                case "Длина строки": 
                    Length(text);
                    break;
                case "Количество гласных":
                    CountVowels(text);
                    break;
                case "Количество согласных":
                    CountConsonants(text);
                    break;
                case "Количество предложений":
                    CountSentences(text);
                    break;
                case "Количество слов в строке":
                    CountWords(text);
                    break;
                default:
                    break;
            }
        }

        public void ShowDop()
        {
            textBox2.Clear();
            textBox2.Show();
            label3.Show();
        }
        public void ShowDop1()
        {
            textBox4.Show();
            label6.Show();
        }
        public void Hide()
        {
            textBox2.Hide();
            label3.Hide();
            textBox4.Hide();
            label6.Hide();
        }
        public void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = "";
        }
        public void ChangeSubstring(string text, string dop, string dop1)
        {
            if (text.Contains(dop))
            {
                text = text.Replace(dop, dop1);
            }
            else
            {
                MessageBox.Show("Некорректные данные!");
            }
            textBox3.Text = text;
        }

        public void DeleteSymbols(string text, string dop)
        {
            textBox3.Text = text.Replace(dop, "");
        }

        public void CharByIndex(string text, string dop)
        {
            if (int.TryParse(dop, out int result))
            {
                if (result < text.Length)
                {
                    textBox3.Text = text.ElementAt(result).ToString();
                }
                else
                {
                    MessageBox.Show("Некорректные данные!");
                }
            }
            else
            {
                MessageBox.Show("Некорректные данные!");
            }
        }

        public void Length(string text)
        {
            textBox3.Text = text.Length.ToString();
        }

        public void CountVowels(string text)
        {
            int result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (Regex.Match(text[i].ToString(), @"[eyuioaуеыаоэяиюё]", RegexOptions.IgnoreCase).Success)
                {
                    result++;
                }
            }
            textBox3.Text = result.ToString();
        }

        public void CountConsonants(string text)
        {
            int result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (Regex.Match(text[i].ToString(), @"[qwrtpsdfghjklzxcvbnmйцкнгшщзхъфвпрлджчсмтьб]", RegexOptions.IgnoreCase).Success)
                {
                    result++;
                }
            }
            textBox3.Text = result.ToString();
        }

        public void CountSentences(string text)
        {
            int result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (Regex.Match(text[i].ToString(), @"[.!?]", RegexOptions.IgnoreCase).Success)
                {
                    result++;
                }
            }
            textBox3.Text = result.ToString();
        }

        public void CountWords(string text)
        {
            int result = 0;
            string[] str = text.Split(' ', ',', '.', '?', '!');
            result = str.Length;
            foreach (var item in str)
            {
                if (item == "")
                {
                    result--;
                }
            }
            textBox3.Text = result.ToString();
        }

    }
}
