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
    public partial class WithFiles : Form
    {
        // ниже вставьте свой путь
        string path = @"C:\\Users\\DELL\\Desktop\\1.txt";
        // для работы на рабочем столе создайте папку и измените путь ниже
        string path2 = @"C:\\Users\\DELL\\Desktop\\2.txt";
        string path3 = @"C:\\Users\\DELL\\Desktop\\3.txt";

        public WithFiles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            File.Create(path).Dispose();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Delete(path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                MessageBox.Show("Файл создан и существует", "Результат");
            }
            else MessageBox.Show("Файл не создан и его не существует", "Результат");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            string content = "обратите внимание, что эта часть полностью переписывает весь текст в файле";
            File.WriteAllText(path, content);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string content = " Добавляет текст в 1 строку";
            File.AppendAllText(path, content);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // при указании true если файл c таким же именем, то он будет перезаписан
            File.Copy(path, path2, true);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string rez = File.GetCreationTime(path).ToString();
            MessageBox.Show(rez, "Возвращает время и дату создания файла");
        }

        private void button8_Click(object sender, EventArgs e)
        {
           MessageBox.Show(File.GetLastAccessTime(path).ToString(), "Покажет когда последний раз проходили действия с файлом");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // перемещает, но следите чтобы файла не было в папке иначе будет ошибка
            try
            {
                File.Move(path, path2);
            }
            catch { MessageBox.Show("Похоже этот файл уже существует"); }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // открыть или создать файл(создается если его не существует)
            File.Open(path, FileMode.OpenOrCreate).Dispose();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(File.ReadAllText(path), "Что внутри файла");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // пас 1 записал в пас 2, а пас 2 в пас 3, пас 1 удален
            try { File.Replace(path, path2, path3); }
            catch { MessageBox.Show("Необходимого файла не существует"); }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // устанавливает сегодняшнюю дату и время
            try { File.SetCreationTime(path, DateTime.Now); }
            catch { MessageBox.Show("Файл не найден"); }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string content = "Создает файл и записывает в него строку и закрывает файл" +
                "если целевой файл существует то он будет переопределен";
            File.WriteAllText(path, content);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // есть ли в файле символ а
            StreamReader sr = new StreamReader(path);
            if (sr.ReadToEnd().Contains("а"))
            {
                MessageBox.Show("В данном файле есть эта буква", "Ответ");
            }
            else MessageBox.Show("В данном файле нет этой буква", "Ответ");

        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Сколько в файле буквы а
            char symbol = 'а';
            string[] lines = File.ReadAllLines(path);
            int count = 0;
            foreach (string line in lines)
            {
                foreach (char c in line)
                {
                    if (c == symbol)
                    {
                        count++;
                    }
                }
            }
            MessageBox.Show(String.Format(count.ToString()));

        }

        private void button17_Click(object sender, EventArgs e)
        {
            // замена символа
            char symbol = 'а';
            char newsymbol = 'q';
            StreamReader sr = new StreamReader(path);
            string lines = sr.ReadToEnd();
            
            
            for(int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == symbol)
                {

                    lines = newsymbol.ToString();
                }
                
                
            }
            
            


        }
    }
}
