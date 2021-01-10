using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    internal class Exc10
    {
        protected int[] ArrNum;
        public Exc10(int k)
        {
            ArrNum = new int[k];
            for(int i = 0; i<ArrNum.Length; i++)
            {
                ArrNum[i] = i + 1;
            }
        }
        public int this[int k]
        {
            get
            {
                return ArrNum[k];
            }
            set
            {
                ArrNum[k]=value;
            }
        }
        public int GetLenght
        {
            get
            {
                return ArrNum.Length;
            }
        }
    }
    internal class Exc101 : Exc10
    {
        protected char[] ArrSymb;
        public Exc101(int k, int n):base(k)
        {
            ArrSymb = new char[n];
            for (int i = 0; i < ArrSymb.Length; i++)
            {
                ArrSymb[i] = (char)('a'+i);
            }
        }
        public char this [int k] //???
        {
            get
            {
                return ArrSymb[k];
            }
            set
            {
                ArrSymb[k] = value;
            }
        }
        public new int[] GetLenght
        {
            get
            {
                return new int[] { ArrNum.Length, ArrSymb.Length };
            }
        }

        public void ShowArrays()
        {
            for(int i =0; i<ArrNum.Length; i++)
            {
                Console.Write(ArrNum[i]+"   ");
            }
            Console.WriteLine();
            for (int i = 0; i < ArrSymb.Length; i++)
            {
                Console.Write(ArrSymb[i] + "   ");
            }
            Console.WriteLine();
        }
    }

    internal class ExcMain10
    {
        public static void DoMain()
        {
            Exc101 ObjA = new Exc101(4, 5);
            ObjA.ShowArrays();            
            Exc10 ObjB = new Exc10(3);
            int lenght = ObjB.GetLenght;
            Console.WriteLine(lenght);
            char a = ObjA[2];
            int b = ObjA[2];
            var c = ObjA[2];
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            ObjB[0] = 13;
            Console.WriteLine(ObjB[0]);
            ObjA[1] = 'R';
            Console.WriteLine(ObjA[1]);
            ObjA.ShowArrays();
            Console.WriteLine(ObjA.GetLenght);
        }
    }
}
