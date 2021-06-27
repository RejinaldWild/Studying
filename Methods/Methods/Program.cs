using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        int x = 8;
        static void Main(string[] args)
        {
            //int x=0;
            //int a = 1;
            //int b = 2;
            //Params(a,b);
            //Params(a,b,5);
            //Params(a, b, i: 10);

            //1
            //Console.WriteLine(DoubleFactorialR(8));
            //Console.WriteLine(DoubleFactorial(8));

            //2
            //Console.WriteLine(QuadSumR(4));
            //Console.WriteLine(QuadSum(4));

            //3
            //int[] array1 = new int[] { 1, 3, 4, 5, 8, 13 };
            //ShowArray(array1);
            //array1 = FirstArrayNumbers(array1,9);
            //ShowArray(array1);

            //4
            //char[] array2 = new char[] { 'Х', 'F', '9' };
            //int[] array3 = new int[array2.Length];
            //array3=ConvertCharToInt(array2);
            //foreach(int i in array3)
            //{
            //    Console.Write($"{i}\t");
            //}

            //5
            //int[] array = new int[] {1,2,1,4,1,6,2 };
            //double mid = MiddleValue(array);
            //ShowArray(array);
            //Console.WriteLine(mid);

            //6
            //int[,] array4 = new int[2, 3] { { 1, 11, 3}, { 10, 13, 6 } };
            //int maxIndexI, maxIndexJ;
            //int maxValue = MaxValueArray(array4,out maxIndexI,out maxIndexJ);
            //Console.WriteLine(maxValue);
            //Console.WriteLine(maxIndexI);
            //Console.WriteLine(maxIndexJ);

            //7
            //int[] array5 = new int[] { 1, 4, 8, 6, 13, 5, 2 };
            //ShowArray(array5);
            //ReverseArray(array5);
            //ShowArray(array5);

            //8
            //int a = 8, b = 13;
            //char d = 'G', g = 'D';
            //ShowArray(FromToArray(a, b));
            //ShowArray(FromToArray(d, g));

            //9
            //int a=7, b=15, c=4, d=13, e=2, f = 6;
            //ShowArray(MinMaxValueArray(a, b, c, d, e, f));

            //10
            string text = "I love coding ";
            char s1 = 'm', s2 = 'u', s3 = 'c', s4 = 'h';
            Console.WriteLine(AddCharsToString(text, s1, s2, s3, s4)); 
        }

        static void ShowArray (int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();
        }

        static void ShowArray(char[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();
        }

        static void Params(int x,int y, int z=3,int i = 4) // метод с недостающими параметрами и определением их по дефолту
        {
            Console.WriteLine(x+y+z+i);
        }
        
        static int DoubleFactorialR(int n) // Рекурсия
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * DoubleFactorialR(n - 2);
        }

        static int DoubleFactorial(int n)
        {
            int tmp=1;
            for(int i = n; i > 0; i-=2)
            {
                if (n == 0 || n == 1) return 1;
                tmp *= i;
            }
            return tmp;
        }

        static int QuadSumR (int n) // Рекурсия
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return n * (n) + QuadSumR((n - 1));
        }

        static int QuadSum (int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            int temp = 0;
            for(int i = 0; i <= n; i++)
            {
                temp += i * i;
            }
            return temp;
        }

        static int[] FirstArrayNumbers (int[] arr, int n)
        {
            int[] array = new int [n];
            if (n <= arr.Length)
            {
                for (int i = 0; i < n; i++)
                {
                    array[i] = arr[i];
                }
                return array;
            }
            else
            {
                for(int i = 0; i<arr.Length; i++)
                {
                    array[i] = arr[i];
                }
                for(int i = arr.Length; i < n; i++)
                {
                    array[i] = 0;
                }
                return array;
            }
        }

        static int[] ConvertCharToInt (char [] arr)
        {
            int[] array = new int[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                array[i] = Convert.ToInt32(arr[i]);
            }
            return array;
        }

        static double MiddleValue (int[] arr)
        {
            double result = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                result += arr[i];                
            }
            result = result / arr.Length;
            return result;
        }

        static int MaxValueArray(int[,] arr, out int maxIndex1, out int maxIndex2)
        {
            int maxValue = 0;
            maxIndex1 = 0; maxIndex2 = 0;
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] > maxValue)
                    {
                        maxValue = arr[i, j];
                        maxIndex1 = i;
                        maxIndex2 = j;
                    }
                }                
            }
            return maxValue;
        }

        static int[] ReverseArray(int [] arr)
        {
            int temp = 0;
            for(int i =0; i < arr.Length / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - i-1];
                arr[arr.Length - i-1] = temp;
            }
            return arr;
        }

        static int[] FromToArray(int n, int m)
        {
            if (n < m)
            {
                int[] array = new int[m - n+1];
                for(int i = 0; i<array.Length; i++)
                {
                    array[i] = n + i;
                }
                array[array.Length-1] = m;
                return array;
            }
            else
            {
                int[] array = new int[n - m+1];
                for(int i = 0; i < array.Length; i++)
                {
                    array[i] = m + i;
                }
                array[array.Length-1] = n;
                return array;
            }                
        }

        static char[] FromToArray(char n, char m)
        {
            if (n < m)
            {
                char[] array = new char[m - n+1];
                for(int i =0; i < array.Length; i++)
                {
                    array[i] = (char)(n + i);                    
                }
                array[array.Length-1] = m;
                return array;
            }
            else
            {                
                char[] array = new char[n - m+1];
                for(int i = 0; i < array.Length; i++)
                {
                    array[i] = (char)(m + i);
                }
                array[array.Length-1] = n;
                return array;                
            }            
        }

        static int[] MinMaxValueArray(params int[] args)
        {
            int minValue = 32013;
            int maxValue = 0;
            int[] array = new int[2];
            for(int i = 0; i < args.Length; i++)
            {
                if (args[i] > maxValue)
                {
                    maxValue = args[i];
                    array[1] = maxValue;
                }
                if (args[i] < minValue)
                {
                    minValue = args[i];
                    array[0] = minValue;
                }
            }
            return array;            
        }

        static string AddCharsToString(string text, params char[] args)
        {
            for(int i = 0; i < args.Length; i++)
            {
                text += args[i];
            }
            return text;
        }
    }
}
