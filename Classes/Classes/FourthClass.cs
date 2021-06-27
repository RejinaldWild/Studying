using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class FourthClass
    {
        private int number;
        private char symb;

        public FourthClass(char symb,int number)
        {
            this.number = number;
            this.symb = symb;
        }
        public FourthClass(double numb)
        {
            symb = (char)(int)numb;
            number = (int)((numb - (int)numb)*100);
        }
        public void Show()
        {
            Console.Write($"{symb}\t {number}");
            Console.WriteLine();
        }
    }
}
