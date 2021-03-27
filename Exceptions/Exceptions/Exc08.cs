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
                symbArr[i] = Convert.ToChar(65+i);
            }
        }
    }

    class Exc08
    {
        public static void MainExc08()
        {
            MyClass08 Mistake = new MyClass08(4);
            try
            {
                foreach(char item in Mistake.symbArr)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
                throw Mistake;
            }
            catch(MyClass08)
            {
                Console.WriteLine(Mistake.Source);
                Console.WriteLine(Mistake.Message);                
                Console.WriteLine(Mistake.StackTrace);
            }
        }
    }
}
