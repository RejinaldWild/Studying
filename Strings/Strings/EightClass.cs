using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class EightClass
    {
        private string str = "";
        public EightClass(string text)
        {
            str = text;            
        }        
        public string Ins( string sub, int index)
        {
            if(index>str.Length)
            {
                return "Substring is out of the limits";
            }
            return str.Insert(index, sub);            
        }

        public override string ToString()
        {
            return str;
        }

        public void Show()
        {
            Console.WriteLine(str);
        }
    }
}
