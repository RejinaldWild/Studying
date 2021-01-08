using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    internal class Exc8
    {
        public int Number;
        public virtual int this[int i]
        {
            get
            {                
                return Number=i;
            }            
        }
    }

    internal class Exc81 : Exc8
    {
        public int SysNumber;
        public string this [int i, int j]
        {
            get
            {
                SysNumber = i;
                return Convert.ToString(SysNumber,toBase:2);
            }            
        }
        public override int this[int i]
        {
            get { return Number + SysNumber; } // ???
        }
    }

    internal class ExcMain8
    {
        public static void DoMain()
        {
            Exc8 AObj = new Exc8();
            AObj.Number = 7;
            Console.WriteLine(AObj.Number);
            Console.WriteLine(AObj[3]);
            Exc81 BObj = new Exc81();
            BObj.SysNumber = 8;
            Console.WriteLine(BObj.SysNumber);
            Console.WriteLine(BObj[8, 2]);
            BObj.Number = 9;
            Console.WriteLine(BObj[13]); //???
        }
    }
}
