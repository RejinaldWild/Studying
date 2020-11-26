using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    class SixthEx
    {
        private int number;
        public SixthEx( int number)
        {
            this.number = number;
        }

        public static bool operator true(SixthEx obj)
        {
            switch (obj.number)
            {
                case 2:
                    return true;
                case 3:
                    return true;
                case 5:
                    return true;
                case 7:
                    return true;
                default: return false;
            }            
        }
        public static bool operator false(SixthEx obj)
        {
            if (obj) return false;
            else return true;
        }
        public static SixthEx operator &(SixthEx obj, SixthEx obj1)
        {
            if (obj) return obj1;
            else return obj;
        }
        public static SixthEx operator |(SixthEx obj, SixthEx obj1)
        {
            if (obj) return obj;
            else return obj1;
        }

        public static void SixthExs()
        {
            SixthEx A = new SixthEx(4);
            SixthEx B = new SixthEx(3);
            SixthEx C = new SixthEx(13);
            SixthEx D = new SixthEx(5);
            Console.WriteLine("A({1}) && A({2}) = {0}", (A && A).number, A.number, A.number);
            Console.WriteLine("A({1}) && B({2}) = {0}", (A && B).number, A.number, B.number);
            Console.WriteLine("A({1}) && C({2}) = {0}", (A && C).number, A.number, C.number);
            Console.WriteLine("A({1}) && D({2}) = {0}", (A && D).number, A.number, D.number);
            Console.WriteLine("B({1}) && A({2}) = {0}", (B && A).number, B.number, A.number);
            Console.WriteLine("B({1}) && B({2}) = {0}", (B && B).number, B.number, B.number);
            Console.WriteLine("B({1}) && C({2}) = {0}", (B && C).number, B.number, C.number);
            Console.WriteLine("B({1}) && D({2}) = {0}", (B && D).number, B.number, D.number);
            Console.WriteLine("C({1}) && A({2}) = {0}", (C && A).number, C.number, A.number);
            Console.WriteLine("C({1}) && B({2}) = {0}", (C && B).number, C.number, B.number);
            Console.WriteLine("C({1}) && C({2}) = {0}", (C && C).number, C.number, C.number);
            Console.WriteLine("C({1}) && D({2}) = {0}", (C && D).number, C.number, D.number);
            Console.WriteLine("D({1}) && A({2}) = {0}", (D && A).number, D.number, A.number);
            Console.WriteLine("D({1}) && B({2}) = {0}", (D && B).number, D.number, B.number);
            Console.WriteLine("D({1}) && C({2}) = {0}", (D && C).number, D.number, C.number);
            Console.WriteLine("D({1}) && D({2}) = {0}", (D && D).number, D.number, D.number);
            Console.WriteLine("___________________________");
            Console.WriteLine("A({1}) || A({2}) = {0}", (A || A).number, A.number, A.number);
            Console.WriteLine("A({1}) || B({2}) = {0}", (A || B).number, A.number, B.number);
            Console.WriteLine("A({1}) || C({2}) = {0}", (A || C).number, A.number, C.number);
            Console.WriteLine("A({1}) || D({2}) = {0}", (A || D).number, A.number, D.number);
            Console.WriteLine("B({1}) || A({2}) = {0}", (B || A).number, B.number, A.number);
            Console.WriteLine("B({1}) || B({2}) = {0}", (B || B).number, B.number, B.number);
            Console.WriteLine("B({1}) || C({2}) = {0}", (B || C).number, B.number, C.number);
            Console.WriteLine("B({1}) || D({2}) = {0}", (B || D).number, B.number, D.number);
            Console.WriteLine("C({1}) || A({2}) = {0}", (C || A).number, C.number, A.number);
            Console.WriteLine("C({1}) || B({2}) = {0}", (C || B).number, C.number, B.number);
            Console.WriteLine("C({1}) || C({2}) = {0}", (C || C).number, C.number, C.number);
            Console.WriteLine("C({1}) || D({2}) = {0}", (C || D).number, C.number, D.number);
            Console.WriteLine("D({1}) || A({2}) = {0}", (D || A).number, D.number, A.number);
            Console.WriteLine("D({1}) || B({2}) = {0}", (D || B).number, D.number, B.number);
            Console.WriteLine("D({1}) || C({2}) = {0}", (D || C).number, D.number, C.number);
            Console.WriteLine("D({1}) || D({2}) = {0}", (D || D).number, D.number, D.number);
            Console.WriteLine("___________________________");
        }        
    }
}
