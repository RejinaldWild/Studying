using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    internal class Alpha2
    {
        public void Hello()
        {
            Console.WriteLine("Hello method from Alpha2");
        }
        public virtual void Hi()
        {
            Console.WriteLine("Hi method from Alpha2");
        }
        public void Show()
        {
            Hello();
            Hi();
            Console.WriteLine();
        }
    }

    internal class Bravo2 : Alpha2
    {
        new public void Hello()
        {
            Console.WriteLine("Hello method from Bravo2");
        }
        public override void Hi()
        {
            Console.WriteLine("Hi method from Bravo2");
        }
    }

    internal class DoL8
    {
        public static void DoMain()
        {
            Alpha2 A = new Alpha2();
            Console.WriteLine("A.Show():");
            A.Show();
            Bravo2 B = new Bravo2();
            Console.WriteLine("B.Hello():");
            B.Hello();
            Console.WriteLine("B.Hi():");
            B.Hi();
            Console.WriteLine("B.Show():");
            B.Show();
            Console.WriteLine("After A=B");
            A = B;
            Console.WriteLine("A.Hello():");
            A.Hello();
            Console.WriteLine("A.Hi():");
            A.Hi();
            Console.WriteLine("A.Show():");
            A.Show();
        }
    }
}
