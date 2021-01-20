using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractsInterfaces
{
    internal abstract class Base08
    {
        public abstract char Symbol { get; }
        public abstract int this [int k] { get; }
        public abstract void Show();
    }
    interface IFirstL8
    {
        char Symbol { get; }
        int this[int k] { get; }
        void Show();
    }
    interface ISecondL8
    {
        char Symbol { get; }
        int this[int k] { get; }
        void Show();
    }

    internal class MyClassL8 : Base08, IFirstL8, ISecondL8
    {
        private char Smb;
        public MyClassL8(char s) : base()
        {
            Smb = s;
        }
        public override char Symbol
        {
            get { return Smb; }
        }
        char IFirstL8.Symbol
        {
            get { return (char)(Smb + 1); }
        }
        public override int this[int k]
        {
            get { return (char)(Smb + k); }
        }

        int ISecondL8.this[int k]
        {
            get { return Smb - k; }
        }
        
        public override void Show()
        {
            Console.WriteLine("Base class :\t\'{0}\'",Symbol);
        }
        void IFirstL8.Show()
        {
            Console.WriteLine("Interface First:\t\'{0}\'", Symbol);
        }
        void ISecondL8.Show()
        {
            Console.WriteLine("Interface Second:\t\'{0}\'", Symbol);
        }
    }

    internal class ExplInterfaceDemo
    {
        public static void Main08()
        {
            MyClassL8 Obj = new MyClassL8('A');
            IFirstL8 A = Obj;
            ISecondL8 B = Obj;
            Obj.Show();
            A.Show();
            B.Show();
            Console.WriteLine("Obj.Symbol=\'{0}\'", Obj.Symbol);
            Console.WriteLine("A.Symbol=\'{0}\'", A.Symbol);
            Console.WriteLine("B.Symbol=\'{0}\'", B.Symbol);
            Console.WriteLine("Obj[10]={0}",Obj[10]);
            Console.WriteLine("A[10]={0}", A[10]);
            Console.WriteLine("B[10]={0}", B[10]);
        }
    }

}
