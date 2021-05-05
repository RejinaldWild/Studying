using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MyClassExc10 <U,T>
    {
        T[] TArr;
        U[] UArr;
        int Index;
        public MyClassExc10(int size)
        {
            TArr = new T[size];
            UArr = new U[size];
        }
        public T this [U k]
        {
            get
            {
                for (int i = 0; i < UArr.Length; i++)
                {
                    if (k.Equals(UArr[i]))
                    {
                        Index--;    // RemoveMethod
                        return TArr[i];
                    }
                }
                throw new KeyNotFoundException("Wrong key value!");                
            }
            set
            {
                if (Index == 0)     //(Index == TArr.Length)
                {
                    UArr[Index] = k;
                    TArr[Index] = value;
                    Index = 1;
                }

                for(int i = 0; i < TArr.Length; i++)
                {
                    if (k.Equals(UArr[i]))
                    {
                        TArr[i] = value;
                        Index--;
                    }
                }

                if (Index == TArr.Length)
                {
                    T[]tArrNew = new T[Index+1];
                    U[]uArrNew = new U[Index+1];
                    for(int i = 0; i < TArr.Length; i++)
                    {
                        tArrNew[i] = TArr[i];
                        uArrNew[i] = UArr[i];
                    }
                    TArr = tArrNew;
                    UArr = uArrNew;
                    UArr[Index] = k;
                    TArr[Index] = value;
                }
                Index++;
            }
        }

    }

    internal class Exc10
    {
        public static void MainExc10()
        {
            MyClassExc10<char,int> A = new MyClassExc10<char,int>(1);
            A['R'] = 2;
            Console.WriteLine(A['R']);
            A['M'] = 63;
            A['D'] = 13;
            A['M'] = 8;
            try
            {
                Console.WriteLine(A['R']);
                Console.WriteLine(A['V']);
            }
            catch(KeyNotFoundException e)
            {
                Console.WriteLine(e.Message); 
            }
            A['S'] = 84;
            A['V'] = 79;
            A['R'] = 96;
            A['C'] = 18;
            Console.WriteLine(A['V']);
        }
    }
}
