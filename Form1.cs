using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WorkwithArray : Form
    {
        int[,] array = new int[100, 100];
        int[,] array1 = new int[100, 100];
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
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Form2 text = new Form2();
            text.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            WithFiles files = new WithFiles();
            files.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WithMethods methods = new WithMethods();
            methods.Show(); 
        }

        private void WorkwithArray_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            int m = int.Parse(textBox1.Text);
            int n = int.Parse(textBox2.Text);
            int[] rezarray = new int[100];
            
            for (int i = 0; i < m; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += array1[i, j];
                   
                }
                listBox2.Items.Add("Сумма" + sum);
            }
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int m = int.Parse(textBox1.Text);
                int n = int.Parse(textBox2.Text);
                dataGridView2.ColumnCount = n;
                dataGridView2.RowCount = m;
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        array1[i, j] = rnd.Next(0, 100);
                        dataGridView2.Rows[i].Cells[j].Value = array1[i, j];

                    }

                }
            }
            catch { MessageBox.Show(String.Format("Вы не ввели значения")); }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int m = int.Parse(textBox1.Text);
            int n = int.Parse(textBox2.Text);
            int[] rezarray = new int[100];
            for(int j = 0; j < m; j++)
{
                int max = array1[0, j];
                for (int i = 1; i < n; i++)
                {
                    if (array1[i, j] > max)
                    {
                        max = array1[i, j];
                    }
                }
                
                rezarray[j] = max;
                listBox3.Items.Add("Наибольший: " + rezarray[j]);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int m = int.Parse(textBox1.Text);
            int n = int.Parse(textBox2.Text);
            bool found = false;
            for (int i = 0; i < m; i++)
            {
                bool ordered = true;
                for (int j = 1; j < n; j++)
                {
                    if (array1[i, j] <= array1[i, j - 1])
                    {
                        ordered = false;
                        break;
                    }
                }
                if (ordered)
                {
                    MessageBox.Show($"Строка №{i} упорядочена по возрастанию");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Нет упорядоченных строк");
            }
        }
    }
}
