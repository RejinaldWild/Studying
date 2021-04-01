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
                symbArr[i] = Convert.ToChar('A'+i);
            }
        }
    }

    class Exc08
    {
        public static void MainExc08()
        {   
            try
            {
                throw new MyClass08(4);
            }
            catch(MyClass08 e)
            {
                foreach (char item in e.symbArr)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
                Console.WriteLine(e.Source);
                Console.WriteLine(e.Message);                
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
