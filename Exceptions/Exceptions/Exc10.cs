using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class MyClass10
    {
        public byte[] arrByte;
        public MyClass10(int size)
        {
            arrByte = new byte[size];
        }
        public int this[int i]
        {
            get
            {
                return arrByte[i];
            }
            set
            {
                try
                {
                    checked { arrByte[i] = (byte)value; }
                }
                catch (OverflowException)
                {
                    arrByte[i] = 255;
                }
            }
        }

    }

    class Exc10
    {
        public static void MainExc10()
        {
            MyClass10 A = new MyClass10(8);
            A[0] = 1;
            A[2] = 7;
            A[5] = -1;
            A[1] = 600;
            foreach(byte item in A.arrByte)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
    }
}
