using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Exc1
    {
        private char symb;        
        public char Alphabet
        {
            get
            {
                if (symb < 'A' || symb > 'Z')
                {
                    return symb = 'A';
                }
                else return symb;
            }
            set
            {
                if (symb >= 'A' | symb <= 'Z') { symb = value; }                
            }
        }
        public static void Excs()
        {
            Exc1 Obj = new Exc1();
            Obj.Alphabet = 'r';
            Console.WriteLine(Obj.Alphabet);
            Obj.Alphabet = 'H';
            Console.WriteLine(Obj.Alphabet);
            Obj.Alphabet = 'A';
            Console.WriteLine(Obj.Alphabet);
        }
    }
}
