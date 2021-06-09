using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    struct StrExc05
    {
        private int FirstField;
        private int SecondField;
        private int ThirdField;
        public StrExc05(int a)
        {
            FirstField = a;
            SecondField = 1;
            ThirdField = 11;
        }
        public StrExc05(int a,int b)
        {
            FirstField = a;
            SecondField = b;
            ThirdField = 12;
        }
        public StrExc05(int a, int b, int c)
        {
            FirstField = a;
            SecondField = b;
            ThirdField = c;
        }

        public int MinProp
        {
            get
            {   
               return Math.Min(FirstField, Math.Min(SecondField, ThirdField));
            }
            set
            {
                ThirdField = value;
            }
        }
        public int MaxProp
        {
            get
            {
                return Math.Max(FirstField, Math.Max(SecondField, ThirdField));
            }
        }
    }

    class Exc05
    {
        public static void MainExc05()
        {
            StrExc05 A = new StrExc05(8);
            StrExc05 B = new StrExc05(5, 7);
            StrExc05 C = new StrExc05(13, 2, 1);
            Console.WriteLine(A.MaxProp);
            Console.WriteLine(B.MaxProp);
            Console.WriteLine(C.MaxProp);
            Console.WriteLine(A.MinProp);
            Console.WriteLine(B.MinProp);
            Console.WriteLine(C.MinProp);
            C.MinProp = 7;
            Console.WriteLine(C.MinProp);
        }
    }
}
