using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WithMethods : Form
    {
        public WithMethods()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Вызов метода процедуры
            Showviz();
        }
        public void Showviz()
        {
            MessageBox.Show(String.Format("Вызов метода процедуры"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Вызов метода функции
            string info = "Функция простейшая";
            MessageBox.Show(String.Format(MethodFunc(info)));

        }
        string MethodFunc(string info)
        {
            return info;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Микро с параметрами
            int number1 = 1;
            int number2 = 2;
            string rez = "Ответ";
            Param(number1, number2, rez);
        }
        public void Param(int number1, int number2, string rez)
        {
            int otv = number1 + number2;

            MessageBox.Show(String.Format(otv + rez, "Микро с параметрами"));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // перегрузка методов
            int number1 = 1;
            int number2 = 3;
            int number3 = 5;
            MessageBox.Show(sum(number1, number2).ToString(), "Первый метод");
            MessageBox.Show(sum(number1, number2, number3).ToString(), "Второй метод");
        }
        public int sum(int number1, int number2)
        {
            int otv = number1 + number2;
            return otv;


        }
        public int sum(int number1, int number2, int number3)
        {
            int otv = number1 + number2 + number3;
            return otv;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Массив как аргумент и возвращаемое значение

            int[] array = new int[5];
            int rez = 0;
            mass(array);
            foreach (int i in mass(array))
            {
                rez += i;
            }
            MessageBox.Show(rez.ToString());

        }
        public int[] mass(int[] mass)
        {

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = i;
            }
            return mass;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Вызов метода из класса
            // Создание объекта класса
            Class aaa = new Class();
            // Реализация инкапсуляции
            aaa.Number1 = 1;
            aaa.Number2 = 2;
            // реализация вызова метода из класса
            MessageBox.Show(aaa.sum(aaa.Number1, aaa.Number2).ToString());



        }

        private void button7_Click(object sender, EventArgs e)
        {
            name nameenum = name.alexey1;
            SayHello(name.alexey4);
        }
        void SayHello(name nameenum)
        {
            switch (nameenum)
            {
                case name.alexey1:
                    MessageBox.Show("Привет алексей 1");
                    break;
                case name.alexey2:
                    MessageBox.Show("Привет алексей 2");
                    break;
                case name.alexey3:
                    MessageBox.Show("Привет алексей 3");
                    break;
                case name.alexey4:
                    MessageBox.Show("Привет алексей 4");
                    break;
            }

        }
        enum name
        {
            alexey1,
            alexey2,
            alexey3,
            alexey4
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<string> people = new List<string>() { "алексей", "Алексей", "Алеша" };
            string rez = "";
            foreach (string person in people)
            {
                rez += person + ", ";
            }
            MessageBox.Show(String.Format(rez));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<string> people = new List<string>() { "алексей", "Алексей", "Алеша" };
            people.Add("Монстр");
            string rez = "";
            foreach (string person in people)
            {
                rez += person + ", ";
            }
            MessageBox.Show(String.Format(rez), "Добавление в конец");
            people.AddRange(new[] { "Жесть", "Крутой" });
            rez = "";
            foreach (string person in people)
            {
                rez += person + ", ";
            }
            MessageBox.Show(String.Format(rez), "Добавление массива");
            people.Insert(0, "Харош");
            rez = "";
            foreach (string person in people)
            {
                rez += person + ", ";
            }
            MessageBox.Show(String.Format(rez), "Добавление в Начало");
            people.InsertRange(1, new string[] { "чел", "Мужик" });
            rez = "";
            foreach (string person in people)
            {
                rez += person + ", ";
            }
            MessageBox.Show(String.Format(rez), "Добавление массива с индекса 1");
            people.RemoveAt(0);
            rez = "";
            foreach (string person in people)
            {
                rez += person + ", ";
            }
            MessageBox.Show(String.Format(rez), "Удаление первого элемента");
            people.Remove("Жесть");
            rez = "";
            foreach (string person in people)
            {
                rez += person + ", ";
            }
            MessageBox.Show(String.Format(rez), "Удаление слова Жесть");
            people.RemoveAll(person => person.Length == 5);
            rez = "";
            foreach (string person in people)
            {
                rez += person + ", ";
            }
            MessageBox.Show(String.Format(rez), "Удаление слов где больше 5 букв");
            people.RemoveRange(1, 2);
            rez = "";
            foreach (string person in people)
            {
                rez += person + ", ";
            }
            MessageBox.Show(String.Format(rez), "Удаляем из списка 2 элемента начиная с индекса 1");
            var existsLength3 = people.Exists(p => p.Length == 3);


            var existsLength7 = people.Exists(p => p.Length == 7);

            // получаем первый элемент с длиной в 3 символа
            var firstWithLength3 = people.Find(p => p.Length == 3);

            // получаем последний элемент с длиной в 3 символа
            var lastWithLength3 = people.FindLast(p => p.Length == 3);

            // получаем все элементы с длиной в 3 символа в виде списка
            List<string> peopleWithLength3 = people.FindAll(p => p.Length == 3);
            
            // переворачиваем весь список
            people.Reverse();
          
            var people2 = new List<string>() { "цауц", "аца", "цацу", "цац", "цац" };
            // переворачиваем часть только 3 элемента с индекса 1
            people2.Reverse(1, 3);
            






        }

        private void button10_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list.Add(2.3); // заносим в список объект типа double
            list.Add(55); // заносим в список объект типа int
            list.AddRange(new string[] { "Hello", "world" }); // заносим в список строковый массив

            string rez = "";
            // перебор значений
            foreach (object o in list)
            {
                rez += o + ", ";
            }
            MessageBox.Show(String.Format(rez, "Вывод"));
            rez = "";
            // удаляем первый элемент
            list.RemoveAt(0);
            // переворачиваем список
            list.Reverse();
            // получение элемента по индексу
            MessageBox.Show(String.Format(list[0].ToString(), "Вывод"));
            // перебор значений
            for (int i = 0; i < list.Count; i++)
            {
                rez += list[i] + ", ";
            }

            MessageBox.Show(String.Format(rez, "Вывод"));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Основные методы класса:\r\n\r\nint Add(object value): добавляет в список объект value\r\n\r\nvoid AddRange(ICollection col): добавляет в список объекты коллекции col, которая представляет интерфейс ICollection - интерфейс, реализуемый коллекциями.\r\n\r\nvoid Clear(): удаляет из списка все элементы\r\n\r\nbool Contains(object value): проверяет, содержится ли в списке объект value. Если содержится, возвращает true, иначе возвращает false\r\n\r\nvoid CopyTo(Array array): копирует текущий список в массив array.\r\n\r\nArrayList GetRange(int index, int count): возвращает новый список ArrayList, который содержит count элементов текущего списка, начиная с индекса index\r\n\r\nint IndexOf(object value): возвращает индекс элемента value\r\n\r\nvoid Insert(int index, object value): вставляет в список по индексу index объект value\r\n\r\nvoid InsertRange(int index, ICollection col): вставляет в список начиная с индекса index коллекцию ICollection\r\n\r\nint LastIndexOf(object value): возвращает индекс последнего вхождения в списке объекта value\r\n\r\nvoid Remove(object value): удаляет из списка объект value\r\n\r\nvoid RemoveAt(int index): удаляет из списка элемент по индексу index\r\n\r\nvoid RemoveRange(int index, int count): удаляет из списка count элементов, начиная с индекса index\r\n\r\nvoid Reverse(): переворачивает список\r\n\r\nvoid SetRange(int index, ICollection col): копирует в список элементы коллекции col, начиная с индекса index\r\n\r\nvoid Sort(): сортирует коллекцию");

        }
    }

}

