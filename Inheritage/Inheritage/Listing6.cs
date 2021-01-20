using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    internal class Base2
    {
        public int Code;
        public void Show()
        {
            Console.WriteLine("Class Base2: " + Code);
        }
        public Base2(int n)
        {
            Code = n;
        }
    }

    internal class MyClass2 : Base2
    {
        new public int Code;
        new public void Show()
        {
            base.Show();
            Console.WriteLine("Class MyClass2: "+Code);
        }
        public void Set(int n)
        {
            base.Code = n;
        }
        public MyClass2(int m, int n) : base(m)
        {
            Code = n;
        }
    }

    internal class DoL6
    {
        public static void DoMain()
        {
            MyClass2 A = new MyClass2(4, 8);
            A.Show();
            Console.WriteLine();
            A.Set(18);
            A.Code = 44;
            A.Show();
        }
    }
}
