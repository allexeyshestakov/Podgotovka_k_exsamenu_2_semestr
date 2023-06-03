using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
