using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class MyClass08:ApplicationException
    {
        public char[] symbArr;
        public MyClass08(int size)
        {
            symbArr = new char[size];
            for(int i = 0; i<symbArr.Length; i++)
            {
                symbArr[i] = 'A';
            }
        }
    }

    class Exc08
    {
        public static void MainExc08()
        {
            MyClass08 A = new MyClass08(4);
            try
            {
                foreach(char item in A.symbArr)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
                throw A;
            }
            catch(MyClass08)
            {
                Console.WriteLine(A.Source);
                Console.WriteLine(A.Message);
                //foreach (char item in A.symbArr)
                //{
                //    Console.Write(item + "\t");
                //}
                Console.WriteLine(A.StackTrace);
            }
        }
    }
}
