using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Exc6
    {
        private int[] Array;
        private int Start;
        public Exc6(int start, int end)
        {
            Array = new int[end-start+1];
            for( int i=0; i < Array.Length; i++)
            {
                Array[i] = i+1;
            }
            Start = start;
        }

        public int this[int index]
        {
            get
            {                
                return Array[index-Start];
            }
            set
            {
                Array[index-Start] = value;
            }
        }

        public void Show()
        {
            for(int i=0;i<Array.Length; i++)
            {
                Console.Write(Array[i]+"    ");
            }
            Console.WriteLine();
        }

        public static void Excs()
        {
            Exc6 Obj = new Exc6(4,8);
            Obj.Show();
            Obj[6] = 1;
            Obj.Show();
        }
    }
}
