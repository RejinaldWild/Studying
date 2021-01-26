using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractsInterfaces
{
    abstract class BaseExc09
    {
        protected char[] Arr;
        public BaseExc09(string txt)
        {
            Arr = new char[txt.Length];
            Array.Copy(txt.ToCharArray(0, txt.Length), Arr, txt.Length);
        }
        public char GetSymb(int n)
        {
            return Arr[n];
        }
        public abstract void SetElem(int n, char s);
    }
    interface IMyInterfaceExc09
    {
        void SetElem(string txt);
        char this[int n] { get;set; }
    }

    internal class MyClassExc09 : BaseExc09, IMyInterfaceExc09
    {
        public MyClassExc09(string txt) : base(txt) { }
        public override void SetElem(int n, char s)
        {
            Arr[n] = s;
        }
        public void SetElem(string txt)
        {
            Arr = new char[txt.Length];
            Array.Copy(txt.ToCharArray(0, txt.Length), Arr, txt.Length);
        }
        public char this[int n]
        {
            get
            {
                return Arr[n];
            }
            set
            {
                Arr[n] = value;
            }
        }
    }

    internal class Exc09
    {
        public static void Main09()
        {

        }
    }
}
