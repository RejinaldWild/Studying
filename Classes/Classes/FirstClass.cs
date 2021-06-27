using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class FirstClass
    {
        private char ch;
        public void Set(char ch)
        {
            this.ch = ch;
        }
        public int Get(char ch)
        {
            return this.ch = ch;
        }
        public void Show(char ch)
        {
            this.ch = ch;
            Console.WriteLine("The code of {0} is {1}", this.ch, (int)this.ch);
        }
    }
}
