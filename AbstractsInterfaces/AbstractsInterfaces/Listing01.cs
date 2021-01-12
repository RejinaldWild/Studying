using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractsInterfaces
{
    internal abstract class BaseL1
    {
        protected int Num;
        public BaseL1(int n)
        {
            Set(n);
        }
        public abstract void Show();
        public abstract void Set(int n);
        public abstract int Get();
    }

    internal class AlphaL1 : BaseL1
    {
        protected int Val;
        public AlphaL1(int n) : base(n)
        {
            Show();
        }
        public override void Show()
        {
            Console.WriteLine("Alpha: {0}, {1}, and {2}", Num,Val,Get());
        }
        public override void Set(int n)
        {
            Num = n;
            Val = n % 10;
        }
        public override int Get()
        {
            return Num / 10;
        }
    }

    internal class BravoL1 : BaseL1
    {
        protected int Val;
        public BravoL1(int n): base(n)
        {
            Show();
        }
        public override void Show()
        {
            Console.WriteLine("Bravo: {0}, {1}, and {2}", Num, Val, Get());
        }
        public override void Set(int n)
        {
            Num = n;
            Val = n % 100;
        }
        public override int Get()
        {
            return Num / 100;
        }
    }

    internal class AbstractDemo
    {
        public static void Main01()
        {
            BaseL1 Obj1;
            AlphaL1 A = new AlphaL1(132);
            BravoL1 B = new BravoL1(321);
            Obj1 = A;
            Console.WriteLine("After using command Obj = A");
            Obj1.Set(894);
            Obj1.Show();
            Obj1 = B;
            Console.WriteLine("After using command Obj = B");
            Obj1.Set(566);
            Obj1.Show();
        }

    }
}
