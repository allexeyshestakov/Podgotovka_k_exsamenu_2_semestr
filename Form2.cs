using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            char FirstChar = str[0];
            MessageBox.Show(FirstChar.ToString(), "Ответ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value = textBox2.Text;   
            string str = textBox1.Text;
            if (str.Contains(value))
            {
                MessageBox.Show("Введенное слово содержит ваше значение", "Ответ");
            }
            else MessageBox.Show("Введенное слово не содержит ваше значение", "Ответ");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string value = textBox3.Text;
            string str = textBox1.Text;
            
            MessageBox.Show(String.Concat(str, value), "Ответ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            MessageBox.Show(str.Trim());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string with = textBox4.Text;

            if (str.EndsWith(with))
            {
                MessageBox.Show("Конец строки совпадает с вашем значением", "Ответ");
            }
            else MessageBox.Show("Конец строки не совпадает с вашем значением", "Ответ");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тут совсем чуть-чуть потому что мне лень, там дальше все примерно одиннаково", "Информация");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string str = richTextBox1.Text;

            if (String.IsNullOrEmpty(str) || String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Введите что-нибудь!");
            }
            else
            {
                if (str.IndexOf(textBox5.Text) != -1)
                {
                    
                    richTextBox1.SelectionStart = str.IndexOf(textBox5.Text);
                    richTextBox1.SelectionLength = textBox5.Text.Length;
                    richTextBox1.SelectionBackColor = Color.Red;
                    MessageBox.Show("Найдено!");
                }
                else
                {
                    MessageBox.Show("Не обнаружено!");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string str = richTextBox1.Text;
            string text = textBox5.Text;
            String[] words = str.Split(new char[] { ' ', ',' });

            int counter = 0;

            foreach (var word in words)
            {
                if (text == word.ToLower())
                    counter++;
            }


            MessageBox.Show(String.Format("Это слово встречается " + counter + " раз"));
        }
    }
}
