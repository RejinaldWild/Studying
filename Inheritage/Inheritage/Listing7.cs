using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    internal class Alpha1
    {
        public int Alpha;
        public Alpha1(int n)
        {
            Alpha = n;
        }
        public virtual void Show()
        {
            Console.WriteLine("Class Alpha1: {0}", Alpha);
        }
    }

    internal class Bravo1:Alpha1
    {
        public int Bravo;
        public Bravo1(int a, int b):base(a)
        {
            Bravo = b;
        }
        public override void Show()
        {
            Console.WriteLine("Class Bravo1: {0} and {1}",Alpha, Bravo);
        }
    }

    internal class Charlie1 : Bravo1
    {
        public int Charlie;
        public Charlie1(int a, int b, int c):base(a,b)
        {
            Charlie = c;
        }
        public override void Show()
        {
            Console.WriteLine("Class Charlie: {0}, {1} and {2}", Alpha, Bravo, Charlie);
        }
    }

    internal class DoL7
    {
        public static void DoMain()
        {
            Alpha1 ObjA = new Alpha1(1);
            ObjA.Show();
            Console.WriteLine();
            Bravo1 ObjB = new Bravo1(2, 4);
            ObjA = ObjB;
            ObjA.Show();
            ObjB.Show();
            Console.WriteLine();
            Charlie1 ObjC = new Charlie1(8, 13, 18);
            ObjA = ObjC;
            ObjB = ObjC;
            ObjA.Show();
            ObjB.Show();
            ObjC.Show();
        }
    }
}
