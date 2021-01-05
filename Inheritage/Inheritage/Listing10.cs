using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    internal class AlphaBase
    {
        protected int Alpha;
        private char[] Symbs;
        public AlphaBase(int a, string txt)
        {
            Alpha = a;
            Symbs = txt.ToCharArray();
        }
        public virtual int Number
        {
            get { return Alpha; }
            set { Alpha = value; }
        }
        public int Length
        {
            get { return Symbs.Length; }
        }
        public char this[int k]
        {
            get { return Symbs[k]; }
            set { Symbs[k] = value; }
        }
        public virtual int this[char s]
        {
            get { return this[s - 'a']; }
            set { this[s - 'a'] = (char)value; }
        }

        public override string ToString()
        {
            string txt="";
            for(int i = 0; i < this.Length; i++)
            {
                txt += this[i] + "|";
            }
            return txt;
        }
    }

    internal class BravoMyClass : AlphaBase
    {
        protected int Bravo;
        public BravoMyClass(int a, int b, string txt) : base(a, txt)
        {
            Bravo = b;
        }
        public override int Number
        {
            get { return Alpha + Bravo; }            
        }
        public override int this[char s]
        {
            get
            {
                if (s == 'a') return Alpha;
                else return Bravo;
            }
            set
            {
                if (s == 'a') Alpha = value;
                else Bravo = value;
            }
        }
    }

    internal class DoL10
    {
        public static void DoMain()
        {
            int k; char s;
            AlphaBase A = new AlphaBase(100, "ABCD");
            Console.WriteLine("Object A:");
            Console.WriteLine(A);
            Console.WriteLine("A.Number="+A.Number);
            A.Number = 150;
            Console.WriteLine("A.Number=" + A.Number);
            for (k = 0, s = 'a'; k < A.Length; k++, s++)
            {
                Console.WriteLine("Symbol \'{0}\' with code {1}", A[k], A[s]);
            }
            A[0] = 'E';
            A['b'] = 'A' + 12;
            Console.WriteLine(A);
            BravoMyClass B = new BravoMyClass(200, 300, "EFGHI");
            Console.WriteLine("Object B:");
            Console.WriteLine(B);
            Console.WriteLine("B.Number="+B.Number);
            B.Number = 400;
            Console.WriteLine("B.Number=" + B.Number);
            B['a'] = 10;
            B['b'] = 20;
            Console.WriteLine("B[\'a\']="+B['a']);
            Console.WriteLine("B[\'b\']="+B['b']);
            Console.WriteLine("B.Number="+B.Number);
            for (k = 0; k < B.Length; k++)
            {
                Console.Write(B[k]+" ");
                B[k] = (char)('a' + k);
            }
            Console.WriteLine();
            Console.WriteLine(B);
        }
    }
}
