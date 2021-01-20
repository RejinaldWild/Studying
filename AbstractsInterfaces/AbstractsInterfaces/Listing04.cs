using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractsInterfaces
{
    internal abstract class Base04
    {
        public abstract int Number { get; set; }
        public Base04(int n)
        {
            Number = n;
            Show();
        }
        public void Show()
        {
            Console.WriteLine("Prop Number = "+Number);
        }
    }

    interface IFirstL4
    {
        void SetNum(int n);
        int GetNum();
    }
    interface ISecondL4
    {
        int this[int k]
        {
            get;
        }
    }

    internal class MyClassL4 : Base04, IFirstL4, ISecondL4
    {
        private int Num;
        public MyClassL4(int n) : base(n) { }
        public void SetNum(int n)
        {
            Num = n;
        }
        public int GetNum()
        {
            return Num;
        }
        public override int Number
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
        public int this [int k]
        {
            get
            {
                int r = Number;
                for (int i=0; i < k; i++)
                {
                    r /= 10;
                }
                return r % 10;
            }
        }
    }

    internal class MoreInterfaceDemo
    {
        public static void Main04()
        {
            int m = 9;
            MyClassL4 Obj = new MyClassL4(12345);
            for(int i = 0; i <= m; i++)
            {
                Console.Write("|" + Obj[m-i]);
            }
            Console.WriteLine("|");
        }
    }
}
