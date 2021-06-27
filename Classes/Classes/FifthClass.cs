using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class FifthClass
    {
        private int number;
        public int Set()
        {
            this.number = 0;
            return number;
        }
        public int Set(int number)
        {
            this.number = number;
            if (number > 100)
            {
                this.number = 100;
            }
            return this.number;
        }
        public void Show()
        {
            Console.WriteLine(number);
        }

        public FifthClass()
        {
            Set();
        }
        public FifthClass(int number)
        {
            Set(number);
        }
    }
}
