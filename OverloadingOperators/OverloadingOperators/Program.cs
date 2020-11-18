using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstExc.FirstExcs();
            //SecondExc.SecondExcs();
            //ThirdExc.ThirdExcs();
        }
    }

    class ThirdExc
    {
        private int num1=0, num2=0;
        public ThirdExc (int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public static bool operator>(ThirdExc obj, ThirdExc obj1)
        {
            if(Math.Pow(obj.num1,2)+ Math.Pow(obj.num2, 2)> Math.Pow(obj1.num1, 2)+ Math.Pow(obj1.num2, 2)) { return true; }
            else return false;
        }
        public static bool operator<(ThirdExc obj, ThirdExc obj1)
        {
            if (Math.Pow(obj.num1, 2) + Math.Pow(obj.num2, 2) < Math.Pow(obj1.num1, 2) + Math.Pow(obj1.num2, 2)) { return true; }
            return false;
        }
        public static void ThirdExcs()
        {
            ThirdExc A = new ThirdExc(1, 2);
            ThirdExc B = new ThirdExc(2, 3);
            ThirdExc C = new ThirdExc(1, 2);
            Console.WriteLine(A>B);
            Console.WriteLine(A<B);
            Console.WriteLine(A>C);
            Console.WriteLine(A<C);
            Console.WriteLine(B>C);
            Console.WriteLine(B<C);
        }
    }

    class SecondExc
    {
        public int[] arr;
        public SecondExc(int arrSize)
        {
            arr = new int[arrSize];            
        }

        public static string operator~(SecondExc obj)
        {
            string txt = "";
            for(int i = 0; i < obj.arr.Length; i++)
            {
                txt += obj.arr[i];
            }
            txt += " - Это текст!";
            return txt;
        }

        public static SecondExc operator++(SecondExc obj)
        {
            int[]temp = new int[obj.arr.Length + 1];
            Array.Copy(obj.arr, temp, obj.arr.Length);
            obj.arr = temp;
            return obj;
        }        

        public static SecondExc operator--(SecondExc obj)
        {   
            Array.Resize(ref obj.arr, obj.arr.Length - 1);
            return obj;
        }

        public static SecondExc operator+(SecondExc obj, SecondExc obj1)
        {
            SecondExc result = new SecondExc(obj.arr.Length + obj1.arr.Length);
            int count = 0;
            for(int i = 0; i < obj.arr.Length; i++)
            {
                result.arr[i] = obj.arr[i];
                count++;
            }
            for(int i = 0; i < obj1.arr.Length; i++)
            {
                result.arr[count] = obj1.arr[i];
                count++;
            }
            return result;
        }

        public static SecondExc operator+(SecondExc obj, int x)
        {
            SecondExc result = new SecondExc(obj.arr.Length + 1);
            Array.Copy(obj.arr, result.arr, obj.arr.Length);
            result.arr[result.arr.Length-1] = x;
            return result;
        }

        public static SecondExc operator+(int x, SecondExc obj)
        {
            SecondExc result = new SecondExc(obj.arr.Length + 1);
            Array.Copy(obj.arr, 0, result.arr, 1, obj.arr.Length);
            result.arr[0] = x;
            return result;
        }

        public static void SecondExcs()
        {
            SecondExc A = new SecondExc(2);
            SecondExc B = new SecondExc(3);
            int number = 7;
            A++;
            B--;
            string showA = ~A;
            Console.WriteLine(showA);
            string showB = ~B;
            Console.WriteLine(showB);
            SecondExc C = A + number;
            Console.WriteLine(~A);
            SecondExc D = number + B;
            SecondExc E = C + D;            
            string showC = ~C;
            Console.WriteLine(showC);
            string showD = ~D;
            Console.WriteLine(showD);
            string showE = ~E;
            Console.WriteLine(showE);
            SecondExc E1 = D + C;
            string showE1 = ~E1;
            Console.WriteLine(showE1);
        }
    }


    class FirstExc
    {
        public char symb;
        public FirstExc (char symb)
        {
            this.symb = symb;
        }

        public static FirstExc operator+(FirstExc obj, int x)
        {
            int temp = obj.symb + x;            
            return new FirstExc((char)temp);
        }

        public static FirstExc operator +(int x, FirstExc obj)
        {
            int temp = obj.symb + x;
            return new FirstExc((char)temp);
        }

        public static int operator-(FirstExc obj1, FirstExc obj2)
        {
            int n = obj1.symb - obj2.symb;
            return n;
        }

        public static FirstExc operator--(FirstExc obj)
        {
            obj.symb--;
            return obj;
        }

        public static FirstExc operator++(FirstExc obj)
        {
            obj.symb++;
            return obj;          
        }

        public static void FirstExcs()
        {
            FirstExc A = new FirstExc('G');
            Console.WriteLine(A.symb);
            A++;
            Console.WriteLine(A.symb);
            FirstExc B = new FirstExc('L');
            Console.WriteLine(B.symb);
            B--;
            Console.WriteLine(B.symb);
            FirstExc C = new FirstExc('c');
            Console.WriteLine(C.symb);
            C = B + 4;
            Console.WriteLine(C.symb);
            C = 2+C;
            Console.WriteLine(C.symb);
            int x = A - B;
            Console.WriteLine(x);
            x = B - A;
            Console.WriteLine(x);
        }
    }

}
