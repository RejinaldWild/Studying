using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractsInterfaces
{
    interface IFirstL7
    {
        void Show();
    }
    interface ISecondL7
    {
        void Show();
    }

    internal class MyClassL7 : IFirstL7, ISecondL7
    {
        public void Show()
        {
            Console.WriteLine("Object class MyClass!");
        }
    }

    internal class ImpInterfaceDemo
    {
        public static void Main07()
        {
            MyClassL7 Obj = new MyClassL7();
            IFirstL7 A = Obj;
            ISecondL7 B = Obj;
            Obj.Show();
            A.Show();
            B.Show();
        }
    }
}
