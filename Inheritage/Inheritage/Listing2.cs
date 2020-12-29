using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    internal class Alpha
    {
        private int Num;
        protected char Symb;
        public int GetNum()
        {
            return Num;
        }
        public char GetSymb()
        {
            return Symb;
        }
        public void SetNum(int n)
        {
            Num = n;
        }
        public void SetSymb(char s)
        {
            Symb = s;
        }
    }

    internal class Bravo : Alpha
    {
        public int Number
        {
            get
            {
                return GetNum();
            }
            set
            {
                SetNum(value);
            }
        }
        public char Symbol
        {
            get
            {
                return Symb;
            }
            set
            {
                Symb=value;
            }
        }
    }

    internal class DoL2
    {
        public static void DoMain()
        {
            Alpha A = new Alpha();
            A.SetNum(4);
            A.SetSymb('M');
            Console.WriteLine("A object: {0} & {1}",A.GetNum(),A.GetSymb());
            Bravo B = new Bravo();
            B.Number = 1;
            B.Symbol = 'R';
            Console.WriteLine("B object: {0} & {1}", B.Number, B.Symbol);
            B.SetNum(8);
            B.SetSymb('V');
            Console.WriteLine("B object: {0} & {1}", B.GetNum(), B.GetSymb());
        }
    }

}
