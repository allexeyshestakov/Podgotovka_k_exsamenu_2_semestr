using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Class
    {

        // Инкапсуляция управление доступом к данным
        private int number1;

        private int number2;
        public int Number1
        {
            get { return number1; }
            set { number1 = value; }
        }
        public int Number2
        {
            get { return number2; }
            set { number2 = value; }
        }

        // Метод в классе
        public int sum(int numb1, int numb2)
        {
            int rez = numb1 + numb2;
            return rez;
        }
        
    }

}
