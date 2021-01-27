using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractsInterfaces
{
    abstract class BaseExc10
    {
        public abstract int Property { get; set; }
        public abstract int this[int n] { get;set; }
        public abstract void Method();
    }
    interface IMyInterfaceExc10
    {
        int Property { get; set; }
        int this[int n] { get; set; }
        void Method();
    }
    interface IMyInterfaceExc101
    {
        int Property { get; set; }
        int this[int n] { get; set; }
        void Method();
    }

    internal class MyClassExc10:BaseExc10,IMyInterfaceExc10,IMyInterfaceExc101
    {
        private int Num;
        public override int Property
        {
            get
            {
                return Num;
            }
            set
            {
                Num = value;
            }
        }
        public override int this[int n]
        {
            get
            {
                return Num;
            }
            set
            {
                Num = value + n;
            }
        }
        public override void Method()
        {
            Num += Num;
        }

        int IMyInterfaceExc10.Property
        {
            get
            {
                return Num;
            }
            set
            {
                Num = value + 2;
            }
        }
        int IMyInterfaceExc10.this[int n]
        {
            get
            {
                return Num+n;
            }
            set
            {
                Num = value + n + n;
            }
        }
        void IMyInterfaceExc10.Method()
        {
            Num += Num + Num;
        }

        int IMyInterfaceExc101.Property
        {
            get
            {
                return Num;
            }
            set
            {
                Num = value + 3;
            }
        }

        int IMyInterfaceExc101.this[int n]
        {
            get
            {
                return Num + n + n;
            }
            set
            {
                Num=value+n+n;
            }
        }
        void IMyInterfaceExc101.Method()
        {
            Num += 3 - 21;
        }
    
    }

    internal class Exc10
    {
        public static void Main10()
        {
            MyClassExc10 A = new MyClassExc10();
            A.Property = 4;
            Console.WriteLine(A.Property);
            A[2] = 8;
            Console.WriteLine(A[2]);
            A.Method();
            Console.WriteLine(A[1]);
            Console.WriteLine();
            IMyInterfaceExc10 R1 = A;
            R1.Property = 5;
            Console.WriteLine(R1.Property);
            R1[3] = 9;
            Console.WriteLine(R1.Property);
            Console.WriteLine(R1[1]);
            R1.Method();
            Console.WriteLine(R1.Property);
            Console.WriteLine();
            IMyInterfaceExc101 L1 = A;
            L1.Property = 8;
            Console.WriteLine(L1.Property);
            L1[4] = 9;
            Console.WriteLine(L1.Property);
            Console.WriteLine(L1[13]);
            L1.Method();
            Console.WriteLine(L1.Property);
        }
    }
}
