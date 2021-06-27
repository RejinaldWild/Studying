using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Exc2
    {
        private int[] Arr;
        private int Counter = 0;

        public Exc2(int num)
        {
            Arr = new int[num];
            for(int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = i + 1;
            }
        }
        
        public int  Prop
        {            
            get
            {                
                int index = Counter;
                if (Counter == (Arr.Length-1))
                    Counter = 0;
                else
                    Counter++;

                return Arr[index];
            }
            set
            {
                Arr[Counter] = value;
            }
        }

        public void Show()
        {
            for(int i = 0; i < Arr.Length; i++)
            {
                Console.Write(Arr[i]+"  ");                
            }
            Console.WriteLine();
        }

        public static void Excs()
        {
            Exc2 Obj = new Exc2(6);
            Obj.Show();
            Console.WriteLine(Obj.Prop);
            Console.WriteLine(Obj.Prop);
            Console.WriteLine(Obj.Prop);
            Obj.Prop = 3;
            Obj.Show();
            Console.WriteLine(Obj.Prop);
            Console.WriteLine(Obj.Prop);
            Obj.Prop = 5;
            Console.WriteLine(Obj.Prop);
            Console.WriteLine(Obj.Prop);
            Console.WriteLine(Obj.Prop);
            Obj.Prop = 8;
            Obj.Show();
        }

    }
}
