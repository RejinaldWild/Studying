using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractsInterfaces
{
    abstract class BaseExc01
    {
        protected int[] Arr1;
        public BaseExc01(int n)
        {
            Arr1 = new int[n];
        }
        public int ArrL
        {
            get { return Arr1.Length; }
            set
            {
                int[] TempArr = new int[value];
                Array.Copy(Arr1, TempArr, TempArr.Length);
                Arr1 = new int[value];
                Array.Copy(TempArr, Arr1, Arr1.Length);
            }
        }
        public abstract void Show();
        public abstract int this[int k] { get;set; }
    }

    internal class MyClassExc01 : BaseExc01
    {
        public MyClassExc01(int n) : base(n)
        {

        }
        public override void Show()
        {
            for(int i = 0; i < ArrL; i++)
            {
                Console.Write(Arr1[i]+"\t");
            }
            Console.WriteLine();
        }
        public override int this[int k]
        {
            get
            {
                return Arr1[k];
            }
            set
            {
                Arr1[k] = value;
            }
        }
    }

    internal class Exc01
    {
        public static void Main01()
        {
            MyClassExc01 A1 = new MyClassExc01(4);
            A1[0] = 4;
            A1[1] = 2;
            Console.WriteLine(A1[0]);
            A1.Show();
            A1.ArrL = 2;
            Console.WriteLine(A1.ArrL);
            A1.Show();
        }
        
    }
}
