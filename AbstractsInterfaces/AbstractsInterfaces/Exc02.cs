using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractsInterfaces
{
    internal abstract class BaseExc02
    {
        protected string Text;
        public BaseExc02(string t)
        {
            Text = t;
        }
        public abstract int Prop { get; }
        public abstract int this[int k] { get; }
        public abstract void Method(string t);
        public abstract void Method1();
    }

    internal class MyClassExc02 : BaseExc02
    {
        public MyClassExc02(string t) : base(t) { }
        public override int Prop
        {
            get { return Text.Length; }
        }
        public override int this[int k]
        {
            get { return Text[k]; }
        }
        public override void Method1()
        {
            Console.WriteLine(Text);
        }
        public override void Method(string t)
        {
            Text = t;
        }
    }

    internal class Exc02
    {
        public static void Main02()
        {
            MyClassExc02 A = new MyClassExc02("Param toldeb");
            Console.WriteLine(A.Prop);
            Console.WriteLine(A[0]);
            A.Method("Chik");
            A.Method1();
        }
    }
}
