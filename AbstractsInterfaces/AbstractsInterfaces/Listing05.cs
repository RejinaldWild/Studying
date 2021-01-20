using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractsInterfaces
{
    interface IFirstL5
    {
        int Number { get; set; }
        int this[int k] { get; }
    }

    interface ISecondL5
    {
        void SetNum(int n);
        int GetNum();
    }
    interface IMyInterfaceL5 : IFirstL5, ISecondL5
    {
        void Show();
    }

    class MyClassL5:IMyInterfaceL5
    {
        private int Num;
        public MyClassL5(int n)
        {
            Number = n;
            Show();
        }

        public int GetNum()
        {
            return Num;
        }
        public void SetNum(int n)
        {
            Num = n;
        }

        public int Number
        {
            get { return GetNum(); }
            set { SetNum(value); }
        }
        public int this[int k]
        {
            get
            {
                int r = Number;
                for(int i = 0; i < k; i++)
                {
                    r /= 10;
                }
                return r % 10;
            }
        }

        public void Show()
        {
            Console.WriteLine("Prop Number = "+ Number);
        }
    }

    internal class InterfaceDemoL5
    {
        public static void Main05()
        {
            int m = 9;
            MyClassL5 Obj = new MyClassL5(12345);
            for (int i = 0; i <= m; i++)
            {
                Console.Write("|" + Obj[m - i]);
            }
            Console.WriteLine("|");
        }
    }
}
