using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexators
{
    class Exc9
    {
        private int[,] matrix;

        public Exc9(int i, int j)
        {
            matrix = new int[i, j];
        }

        public int this[int a, int b]
        {
            get
            {
                return matrix[a, b];
            }
            set
            {
                matrix[a, b] = value;
            }
        }

        public int this[int k]
        {
            get
            {
                int max = 0;
                if (k < matrix.GetLength(0))
                {
                    for(int j=0; j < matrix.GetLength(1); j++)
                    {
                        if (max < matrix[k, j])
                        {
                            max = matrix[k, j];                                
                        }
                    }
                }            
                return max;
            }
            set
            {
                int max = 0;
                if (k < matrix.GetLength(0))
                {
                    int cl = 0;
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (max < matrix[k, j])
                        {
                            max = matrix[k, j];
                            cl = j;
                        }
                    }
                    matrix[k, cl] = value;
                }
            }
        }

        public void ShowArray()
        {
            for(int i=0; i<matrix.GetLength(0);i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write( matrix[i,j]+ "   ");
                }
                Console.WriteLine();
            }
        }

        public static void Excs()
        {
            Exc9 Obj = new Exc9(2, 3);
            Obj[1, 1] = 6;
            Obj.ShowArray();
            Obj[1, 1] = 13;
            Console.WriteLine(Obj[1,1]);
            Obj[0, 0] = 13;
            Obj[0, 1] = 18;
            Obj[0, 2] = 18;
            Obj.ShowArray();
            Console.WriteLine(Obj[0,0]);
            Obj[0] = 24;
            Obj.ShowArray();
            Console.WriteLine(Obj[0]);
            Console.WriteLine(Obj[1]);
            
        }
    }
}
