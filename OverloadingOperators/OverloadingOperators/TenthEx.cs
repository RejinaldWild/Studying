using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    class TenthEx
    {
        private char symb;
        public TenthEx(char symb)
        {
            this.symb = symb;
        }
        
        public static string operator +(TenthEx obj, TenthEx obj1)
        {            
            string txt = obj.symb.ToString();
            txt += obj1.symb.ToString();
            return txt;
        }

        public static string operator +(string text, TenthEx obj)
        {
            text += obj.symb.ToString();
            return text;
        }

        public static int operator -(TenthEx obj, TenthEx obj1)
        {
            int result = obj.symb;
            result-= obj1.symb;
            return result;
        }

        public static int operator -(int number, TenthEx obj)
        {
            int result = number;
            result -= obj.symb;
            return result;
        }
        //public static TenthEx operator -(TenthEx obj, int number)
        //{
        //    TenthEx T = new TenthEx(obj.symb);            
        //    T -= number;
        //    return T;
        //} По заданию не требуют

        public static void TenthExs()
        {
            TenthEx A = new TenthEx('M');
            TenthEx B = new TenthEx('G');
            TenthEx C = new TenthEx('V');
            string text;
            int num;
            text = A + B;
            Console.WriteLine(text);
            text += A;
            Console.WriteLine(text);            
            //B += A;
            Console.WriteLine(B.symb);
            num = A - B;
            Console.WriteLine(num);
            num -= B;
            Console.WriteLine(num);
            //B -= num;
            //Console.WriteLine(B); По заданию не требуют
            int num1;
            num1 = A - C;
            Console.WriteLine(num1);
        }
    }
}
