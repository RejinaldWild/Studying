using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class CommonMistake:Exception
    {
        public CommonMistake():base()
        {
            Console.WriteLine("Common Mistake Exception");
        }
    }

    class MyMistake:ApplicationException
    {
        public MyMistake() : base()
        {
            Console.WriteLine("MyMistake Exception");
        }
    }

    class MyClass09
    {
        private char[] arrChar;
        public MyClass09(int size)
        {
            arrChar = new char[size];
        }

        public void CheckIndex(int i)
        {
            if (i > arrChar.Length - 1)
            {
                throw new CommonMistake();
            }
            else if (i < 0)
            {
                throw new MyMistake();
            }
        }

        public char this[int i]
        {
            get
            {
                CheckIndex(i);
                return arrChar[i];
            }
            set
            {
                CheckIndex(i);
                arrChar[i] = value;
            }
        }
    } 

    class Exc09
    {
        public static void MainExc09()
        {
            MyClass09 A = new MyClass09(4);
            try
            {
                A[2] = 'R';
                A[0] = 'M';
                Console.WriteLine(A[0]);
                Console.WriteLine(A[1]);
                Console.WriteLine(A[2]);
                Console.WriteLine(A[3]);
                //A[5] = 'D';
                A[-1] = 'G';
                Console.WriteLine(A[5]);
                Console.WriteLine(A[-1]);
            }
            catch (MyMistake e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
            }
            catch (CommonMistake e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
            }

        }
    }
}
