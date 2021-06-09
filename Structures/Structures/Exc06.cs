using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    struct StrExc06
    {
        private int First;
        private int Second;

        public StrExc06(int a,int b)
        {
            First = a;
            Second = b;
        }

        public static StrExc06 operator +(StrExc06 A, StrExc06 B)
        {
            StrExc06 C = new StrExc06();
            C.First = A.First + B.First;
            C.Second = A.Second + B.Second;
            return C;
        }
        public static StrExc06 operator *(StrExc06 A, StrExc06 B)
        {
            StrExc06 C = new StrExc06();
            C.First = A.First * B.First;
            C.Second = A.Second * B.Second;
            return C;
        }
        public static StrExc06 operator -(StrExc06 A, StrExc06 B)
        {
            StrExc06 C = new StrExc06();
            C.First = A.First - B.First;
            C.Second = A.Second - B.Second;
            return C;
        }
        public static int operator ~(StrExc06 A)
        {
            return Math.Max(A.First, A.Second);
        }
        public static int operator !(StrExc06 A)
        {
            return Math.Min(A.First, A.Second);
        }
    }

    class Exc06
    {
        public static void MainExc06()
        {
            StrExc06 Astr = new StrExc06(4, 2);
            StrExc06 Bstr = new StrExc06(5, 9);
            StrExc06 Cstr = Astr + Bstr;
            Cstr = Astr * Bstr;
            Cstr = Astr - Bstr;
            int min = !Astr;
            int max = ~Cstr;
            min = !Bstr;
            max = ~Bstr;
        }
    }
}
