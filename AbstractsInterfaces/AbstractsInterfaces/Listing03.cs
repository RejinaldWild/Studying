using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractsInterfaces
{
    interface MyInterfaceL3
    {
        void Show();
        void SetNum(int n);
        int GetNum();
        int Number { get; set; }
        int this[int k] { get; }
    }

    internal class MyClassL3 : MyInterfaceL3
    {
        private int Num;
        public MyClassL3(int n)
        {
            Number = n;
        }
        public void Show()
        {
            Console.WriteLine("Prop Number = "+ Number);
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
            get
            {
                return GetNum();
            }
            set
            {
                SetNum(value);
            }
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
    }

    internal class InterfaceDemo
    {
        public static void Main03()
        {
            int m = 9;
            MyClassL3 Obj1 = new MyClassL3(12345);
            for(int i = 0; i <= m; i++)
            {
                Console.Write("|"+Obj1[m-i]);
            }
            Console.WriteLine("|");
        }
    }
}
