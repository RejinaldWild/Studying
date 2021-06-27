using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Listing12
    {
        private char[,] symbs;
        public Listing12(int a, int b)
        {
            symbs = new char[a,b];
            for(int i=0; i < symbs.GetLength(0); i++)
            {
                for(int j = 0; j<symbs.GetLength(1); j++)
                {
                    symbs[i, j] = '0';
                }
            }
        }

        public void Show()
        {
            for (int i = 0; i < symbs.GetLength(0); i++)
            {
                for (int j = 0; j < symbs.GetLength(1); j++)
                {
                    Console.Write(symbs[i,j]+" ");
                }
                Console.WriteLine();
            }
        }

        public char this[int i, int j]
        {
            get { return symbs[i, j]; }
            set { symbs[i, j] = value; }
        }

        public static void ListingFunc()
        {
            Listing12 Obj = new Listing12(2,3);
            Obj.Show();
            Obj[0, 0] = 'A';
            Obj[1, 2] = 'Z';
            Console.WriteLine();
            Obj.Show();
            Console.WriteLine("Проверка:");
            Console.WriteLine("Obj[0, 0] = {0}", Obj[0, 0]);
            Console.WriteLine("Obj[1, 1] = {0}", Obj[1, 1]);
            Console.WriteLine("Obj[1, 2] = {0}", Obj[1, 2]);
        }
    }
}
