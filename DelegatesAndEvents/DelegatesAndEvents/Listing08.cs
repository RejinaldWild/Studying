using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate char MyDelegate08(int n);

    internal class MyClassL8
    {
        public char Symbol;
        public MyDelegate08 Get;
        public MyClassL8(char s, MyDelegate08 md)
        {
            Symbol = s;
            Get = md;
        }
        public void Set(MyDelegate08 md)
        {
            Get = md;
        }
    }

    internal class AnonymMethAsArgDemo
    {
        internal class Listing08
        {
            public static void Main08()
            {
                MyClassL8 Obj = new MyClassL8('K',
                    delegate (int n)
                    {
                        return (char)('A' + n);
                    }
                );
                Console.WriteLine("Symbol: \'{0}\'",Obj.Get(3));
                Obj.Set(
                    delegate (int n)
                    {
                        return (char)(Obj.Symbol + n);
                    });
                Console.WriteLine("Symbol: \'{0}\'", Obj.Get(3));
            }
        }
    }
}
