using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    internal class MyClassL15
    {
        private string text;
        public MyClassL15(string t)
        {
            text = t;
        }
        public char this[int k]=>text[k];
        public int Length => text.Length;
    }

    internal class MoreLambdaDemo
    {
        internal class Listing15
        {
            public static void Main15()
            {
                MyClassL15 Obj = new MyClassL15("OGOd");
                for (int k = 0; k <Obj.Length;k++)
                {
                    Console.Write("|"+Obj[k]);
                }
                Console.WriteLine("|");
            }
        }
    }
    
}
