using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate char MyDelegate12(int n);

    internal class MyClassL12
    {
        public char Symbol;
        public MyDelegate12 Get;
        public MyClassL12(char s, MyDelegate12 md)
        {
            Symbol = s;
            Get = md;
        }
        public void Set(MyDelegate12 md)
        {
            Get = md;
        }
    }

    internal class LambdaAsArgDemo
    {
        internal class Listing12
        {
            public static void Main12()
            {
                MyClassL12 Obj = new MyClassL12('K', n => (char)('A'+n));
                //    delegate (int n)
                //    {
                //        return (char)('A' + n);
                //    }
                //);
                Console.WriteLine("Symbol: \'{0}\'", Obj.Get(3));
                Obj.Set(n=>(char)(Obj.Symbol+n));
                    //delegate (int n)
                    //{
                    //    return (char)(Obj.Symbol + n);
                    //});
                Console.WriteLine("Symbol: \'{0}\'", Obj.Get(3));
            }
        }
    }
}
