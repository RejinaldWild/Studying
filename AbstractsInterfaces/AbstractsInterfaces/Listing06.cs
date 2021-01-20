using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractsInterfaces
{
    interface IMyInterfaceL6
    {
        char GetChar(int n);
        char this[int k] { get; }
    }

    internal class AlphaL6 : IMyInterfaceL6
    {
        private char Symb;
        public AlphaL6(char s)
        {
            Symb = s;
        }
        public char GetChar(int n)
        {
            return (char)(Symb + n);
        }
        public char this[int k]
        {
            get { return GetChar(k); }
        }
    }

    internal class BravoL6 : IMyInterfaceL6
    {
        private string Text;
        public BravoL6(string txt)
        {
            Text = txt;
        }

        public char GetChar(int k)
        {
            return Text[k%Text.Length];
        }
        public char this[int k]
        {
            get { return GetChar(k); }
        }
    }

    internal class InterfaceVarDemo
    {
        public static void Main06()
        {
            int m = 5;
            IMyInterfaceL6 R;
            R = new AlphaL6('F');
            Console.WriteLine("Symbols from \'{0}\' to \'{1}\'", R.GetChar(-m), R.GetChar(m));
            for (int i = -m; i <= m; i++)
            {
                Console.Write("|"+R[i]);
            }
            Console.WriteLine("|");
            R = new BravoL6("bravo");
            Console.WriteLine("Symbols from \'{0}\' to \'{1}\'", R.GetChar(0), R.GetChar(2*m+1));
            for (int i = 0; i <= 2*m+1; i++)
            {
                Console.Write("|" + R[i]);
            }
            Console.WriteLine("|");
        }
    }
}
