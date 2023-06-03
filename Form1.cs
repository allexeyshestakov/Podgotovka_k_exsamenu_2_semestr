using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WorkwithArray : Form
    {
        int[,] array = new int[100, 100];
        public WorkwithArray()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int m = int.Parse(textBox1.Text);
                int n = int.Parse(textBox2.Text);
                dataGridView1.ColumnCount = n;
                dataGridView1.RowCount = m;
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        array[i, j] = rnd.Next(0, 100);
                        dataGridView1.Rows[i].Cells[j].Value = array[i, j];
                    }

                }
            }
            catch { MessageBox.Show(String.Format("Вы не ввели значения")); }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int m = int.Parse(textBox1.Text);
            int n = int.Parse(textBox2.Text);

            // поиск максимального значения
            int max = array[0, 0];
            int iForMax = 0;
            int jForMax = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                        iForMax = i;
                        jForMax = j;

                    }

                }

            }
            listBox1.Items.Add(String.Format("Максимальный элемент: " + Environment.NewLine +
                " Строка: \n" + iForMax + " Столбец: " + jForMax + Environment.NewLine + " Значение: " + max));

            // поиск минимального значения
            int min = array[0, 0];
            int iForMin = 0;
            int jForMin = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                        iForMin = i;
                        jForMin = j;

                    }

                }

            }
            listBox1.Items.Add("Минимальный элемент: " + Environment.NewLine +
                " Строка: " + iForMin + " Столбец: " + jForMin + Environment.NewLine + " Значение: " + min);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Сортировка массива по возрастанию

            int m = int.Parse(textBox1.Text);
            int n = int.Parse(textBox2.Text);
            int[] row = new int[m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    row[j] = array[i, j];
                BubbleSort(row);
                Insert(true, i, row, array);
            }
            int[] col = new int[m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    col[j] = array[j, i];
                BubbleSort(col);
                Insert(false, i, col, array);
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    dataGridView1.Rows[i].Cells[j].Value = array[i, j];
                }

            }
        }

        public static void Insert(bool isRow, int dim, int[] source, int[,] dest)
        {
            for (int k = 0; k < source.Length; k++)
            {
                if (isRow)
                    dest[dim, k] = source[k];
                else
                    dest[k, dim] = source[k];
            }
        }

        static void BubbleSort(int[] inArray)
        {
            for (int i = 0; i < inArray.Length; i++)
                for (int j = 0; j < inArray.Length - i - 1; j++)
                {
                    if (inArray[j] > inArray[j + 1])
                    {
                        int temp = inArray[j];
                        inArray[j] = inArray[j + 1];
                        inArray[j + 1] = temp;
                    }
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
