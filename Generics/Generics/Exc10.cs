using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MyClassExc10 <T, U>
    {
        T[] TArr;
        U[] UArr;
        int index;
        public MyClassExc10(int size)
        {
            TArr = new T[size];
            UArr = new U[size];
        }
        public T this [U k]
        {
            get
            {
                try
                {
                    for (int i = 0; i < UArr.Length; i++)
                    {
                        if (k.Equals(UArr[i]))
                        {
                            index--;
                            return TArr[i];
                        }
                    }
                    throw new KeyNotFoundException("Wrong key value!");
                }
                catch (KeyNotFoundException e)
                {
                    Console.WriteLine(e.Message);                   
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
                return TArr[0]; //???
            }
            set
            {
                if (index == 0)
                {
                    UArr[index] = k;
                    TArr[index] = value;
                    index = 1;
                }

                for(int i = 0; i < TArr.Length; i++)
                {
                    if (k.Equals(UArr[i]))
                    {
                        TArr[i] = value;
                        index--;
                    }
                }

                if (index == TArr.Length)
                {
                    T[]TArrNew = new T[index+1];
                    U[]UArrNew = new U[index+1];
                    for(int i = 0; i < TArr.Length; i++)
                    {
                        TArrNew[i] = TArr[i];
                        UArrNew[i] = UArr[i];
                    }
                    TArr = TArrNew;
                    UArr = UArrNew;
                    UArr[index] = k;
                    TArr[index] = value;
                }
                index++;
            }
        }

    }

    internal class Exc10
    {
        public static void MainExc10()
        {
            MyClassExc10<int,char> A = new MyClassExc10<int,char>(1);
            A['R'] = 2;
            Console.WriteLine(A['R']);
            A['M'] = 63;
            A['D'] = 13;
            A['M'] = 8;
            Console.WriteLine(A['R']);
            Console.WriteLine(A['V']);
            A['S'] = 84;
            A['V'] = 79;
            A['R'] = 96;
            A['C'] = 18;
            Console.WriteLine(A['V']);
            
        }
    }
}
