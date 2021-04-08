using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    internal class ClassExc03<T>
    {
        private T element;
        public T NameElement
        {
            get
            {
                return element;
            }
            set
            {
                element = value;
            }
        }
    }

    internal class Exc03
    {
        public static void MainExc03()
        {
            ClassExc03<int> ObjA = new ClassExc03<int>();
            ObjA.NameElement = 13;
            Console.WriteLine(ObjA.NameElement);
            ClassExc03<char> ObjB = new ClassExc03<char>();
            ObjB.NameElement = 'R';
            Console.WriteLine(ObjB.NameElement);
        }
    }
}
