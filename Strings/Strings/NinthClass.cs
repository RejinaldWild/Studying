using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class NinthClass
    {
        private char symb;
        private string str;
        public NinthClass(string str,char symb)
        {
            this.str = str;
            this.symb = symb;
        }
        public string[] ArrStr()
        {
            string[] array;
            array = str.Split(symb);
            return array;
        }       

        public override string ToString()
        {
            string[] array = ArrStr();
            string text="";            
            for(int i = 0; i < array.Length; i++)
            {
                text += array[i]+'|';
            }            
            return text;
        }
    }
}
