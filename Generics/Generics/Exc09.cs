using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MyClassExc09<T>
    {
        public T[] TArr;
        public MyClassExc09(int size)
        {
            TArr = new T[size];
        }

        public static MyClassExc09<T> operator +(MyClassExc09<T> obj1, MyClassExc09<T> obj2)
        {
            MyClassExc09<T> ObjTemp = new MyClassExc09<T>(obj1.TArr.Length + obj2.TArr.Length);
            for(int i = 0; i < obj1.TArr.Length; i++)
            {
                ObjTemp.TArr[i] = obj1.TArr[i];
            }
            for(int i = obj1.TArr.Length; i < obj1.TArr.Length+obj2.TArr.Length; i++)
            {
                ObjTemp.TArr[i] = obj2.TArr[i- obj1.TArr.Length];
            }
            return ObjTemp;
        }
    }

    internal class Exc09
    {
        public static void MainExc09()
        {
            MyClassExc09<int> A = new MyClassExc09<int>(3);
            for(int i = 0; i < A.TArr.Length; i++)
            {
                A.TArr[i] = i + 12;
            }
            MyClassExc09<int> B = new MyClassExc09<int>(8);
            for (int i = 0; i < B.TArr.Length; i++)
            {
                B.TArr[i] = i * i;
            }
            MyClassExc09<int> C = A + B;
        }
    }
}
