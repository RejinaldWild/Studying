using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class ClassExc04<T>
    {
        T[] arr;
        public ClassExc04(T[] arr)
        {
            this.arr = arr;
        }

        public T this[int k]
        {
            get
            {
                return arr[k];
            }
            set
            {
                arr[k] = value;
            }
        }

        public void Show()
        {
            foreach (T item in arr)
            {
                Console.Write(" | " + item);
            }
            Console.WriteLine(" |");
        }
        
    }

    internal class Exc04
    {
        public static void MainExc04()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            ClassExc04<int> ObjA = new ClassExc04<int>(array);
            char[] charray = new char[] { 'C', 'D', 'R', 'M' };
            ClassExc04<char> ObjB = new ClassExc04<char>(charray);
            ObjA[4] = 13;
            Console.WriteLine(ObjA[4]);
            ObjA.Show();
            ObjB[1] = 'T';
            Console.WriteLine(ObjB[1]);
            ObjB.Show();
        }
    }
}
