using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    internal class AlphaBase1
    {
        public int Code;
        public AlphaBase1(int n)
        {
            Code = n;
            Console.WriteLine("AlphaBase1 with one argument: {0}",Code);
        }
        public AlphaBase1()
        {
            Code = 123;
            Console.WriteLine("AlphaBase1 without arguments: {0}", Code);
        }
    }

    internal class BravoClass1 : AlphaBase1
    {
        public char Symb;
        public BravoClass1(int n, char s) : base(n)
        {
            Symb = s;
            Console.WriteLine("BravoClass1 with two arguments: {0} and \'{1}\'", Code, Symb);
        }
        public BravoClass1(int n) : base(n)
        {
            Symb = 'A';
            Console.WriteLine("BravoClass1 with int-argument: {0} and \'{1}\'", Code, Symb);
        }
        public BravoClass1(char s) : base(8)
        {
            Symb = s;
            Console.WriteLine("BravoClass1 with char-argument: {0} and \'{1}\'", Code, Symb);
        }
        public BravoClass1() : base()
        {
            Symb = 'O';
            Console.WriteLine("BravoClass1 without arguments: {0} and \'{1}\'", Code, Symb);
        }
    }

    internal class DoL3
    {
        public static void DoMain()
        {
            AlphaBase1 A1 = new AlphaBase1();
            Console.WriteLine();
            AlphaBase1 A2 = new AlphaBase1(100);
            Console.WriteLine();
            BravoClass1 B1 = new BravoClass1();
            Console.WriteLine();
            BravoClass1 B2 = new BravoClass1('M');
            Console.WriteLine();
            BravoClass1 B3 = new BravoClass1(13);
            Console.WriteLine();
            BravoClass1 B4 = new BravoClass1(69, 'X');
        }
    }
}
