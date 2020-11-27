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
            //FirstEx.FirstExs();
            //SecondEx.SecondExs();
            //ThirdEx.ThirdExs();
            //FourthEx.FourthExs();
            //FifthEx.FifthExs();
            //SixthEx.SixthExs();            
            //SeventhEx.SeventhExs();
            //EighthEx.EighthExs();
            //NinthEx.NinthEsx();

        }
    }

    class FifthEx
    {
        private char symb;
        private int number;        

        public FifthEx(char symb,int number)
        {
            this.symb = symb;
            this.number = number;
        }

        public static bool operator true(FifthEx obj)
        {
            if (10 > Math.Abs(obj.symb-obj.number)) { return true; }
            else return false;
        }
        public static bool operator false(FifthEx obj)
        {
            if (10 > Math.Abs(obj.symb-obj.number)) { return false; }
            else return true;
        }

        static public void FifthExs()
        {
            FifthEx A = new FifthEx('M', 3);
            FifthEx B = new FifthEx('R', 84);
            Console.WriteLine(Test(A));
            Console.WriteLine(Test(B));            
        }

        public static string Test(FifthEx obj)
        {
            if (obj)
            {
                return obj.symb.ToString();
            }
            else
            {
                return "It is not true";
            }
        }
    }

    class FourthEx
    {
        private int number;
        private string txt;
        public FourthEx(int number, string txt)
        {
            this.number = number;
            this.txt = txt;
        }

        public static bool operator>(FourthEx obj,FourthEx obj1)
        {
            return obj.txt.Length > obj1.txt.Length;
        }
        public static bool operator<(FourthEx obj, FourthEx obj1)
        {
            return obj.txt.Length < obj1.txt.Length;
        }
        public static bool operator >=(FourthEx obj, FourthEx obj1)
        {
            return obj.number >= obj1.number;
        }
        public static bool operator<=(FourthEx obj, FourthEx obj1)
        {            
            return obj.number <= obj1.number;
        }
        public static bool operator==(FourthEx obj, FourthEx obj1)
        {           
            return (obj.number == obj1.number) && (obj.txt == obj1.txt);
        }
        public static bool operator!=(FourthEx obj, FourthEx obj1)
        {
            return !(obj.number == obj1.number) || !(obj.txt == obj1.txt);
        }

        public override int GetHashCode()
        {            
            return txt[0]^number;
        }
        public override bool Equals(object obj)
        {
            FourthEx t = (FourthEx)obj;
            return (number==t.number)&&(txt==t.txt);
        }

        public static void FourthExs()
        {
            FourthEx A = new FourthEx(2, "hi");
            FourthEx B = new FourthEx(3, "Archi");
            FourthEx C = new FourthEx(3, "Archi");
            Console.WriteLine("A > B? = {0}",A > B);
            Console.WriteLine("A < B? = {0}", A < B);
            Console.WriteLine("A >= B? = {0}", A >= B);
            Console.WriteLine("A <= B? = {0}", A <= B);
            Console.WriteLine("C = B? = {0}", B == C);
            Console.WriteLine("A != B? = {0}", A != B);
            Console.WriteLine("A != B? = {0}", C != B);            
            Console.WriteLine("C = B? = {0}", B.Equals(C));
            Console.WriteLine("A = B? = {0}", B.Equals(A));
            Console.WriteLine(A.GetHashCode());
            Console.WriteLine(B.GetHashCode());
            Console.WriteLine(C.GetHashCode());
        }
    }

    class ThirdEx
    {
        private int num1=0, num2=0;
        public ThirdEx (int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public static bool operator>(ThirdEx obj, ThirdEx obj1)
        {
            if(Math.Pow(obj.num1,2)+ Math.Pow(obj.num2, 2)> Math.Pow(obj1.num1, 2)+ Math.Pow(obj1.num2, 2)) { return true; }
            else return false;
        }
        public static bool operator<(ThirdEx obj, ThirdEx obj1)
        {
            if (Math.Pow(obj.num1, 2) + Math.Pow(obj.num2, 2) < Math.Pow(obj1.num1, 2) + Math.Pow(obj1.num2, 2)) { return true; }
            return false;
        }
        public static void ThirdExs()
        {
            ThirdEx A = new ThirdEx(1, 2);
            ThirdEx B = new ThirdEx(2, 3);
            ThirdEx C = new ThirdEx(1, 2);
            Console.WriteLine(A>B);
            Console.WriteLine(A<B);
            Console.WriteLine(A>C);
            Console.WriteLine(A<C);
            Console.WriteLine(B>C);
            Console.WriteLine(B<C);
        }
    }

    class SecondEx
    {
        public int[] arr;
        public SecondEx(int arrSize)
        {
            arr = new int[arrSize];            
        }

        public static string operator~(SecondEx obj)
        {
            string txt = "";
            for(int i = 0; i < obj.arr.Length; i++)
            {
                txt += obj.arr[i];
            }
            txt += " - Это текст!";
            return txt;
        }

        public static SecondEx operator++(SecondEx obj)
        {
            int[]temp = new int[obj.arr.Length + 1];
            Array.Copy(obj.arr, temp, obj.arr.Length);
            obj.arr = temp;
            return obj;
        }        

        public static SecondEx operator--(SecondEx obj)
        {   
            Array.Resize(ref obj.arr, obj.arr.Length - 1);
            return obj;
        }

        public static SecondEx operator+(SecondEx obj, SecondEx obj1)
        {
            SecondEx result = new SecondEx(obj.arr.Length + obj1.arr.Length);
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

        public static SecondEx operator+(SecondEx obj, int x)
        {
            SecondEx result = new SecondEx(obj.arr.Length + 1);
            Array.Copy(obj.arr, result.arr, obj.arr.Length);
            result.arr[result.arr.Length-1] = x;
            return result;
        }

        public static SecondEx operator+(int x, SecondEx obj)
        {
            SecondEx result = new SecondEx(obj.arr.Length + 1);
            Array.Copy(obj.arr, 0, result.arr, 1, obj.arr.Length);
            result.arr[0] = x;
            return result;
        }

        public static void SecondExs()
        {
            SecondEx A = new SecondEx(2);
            SecondEx B = new SecondEx(3);
            int number = 7;
            A++;
            B--;
            string showA = ~A;
            Console.WriteLine(showA);
            string showB = ~B;
            Console.WriteLine(showB);
            SecondEx C = A + number;
            Console.WriteLine(~A);
            SecondEx D = number + B;
            SecondEx E = C + D;            
            string showC = ~C;
            Console.WriteLine(showC);
            string showD = ~D;
            Console.WriteLine(showD);
            string showE = ~E;
            Console.WriteLine(showE);
            SecondEx E1 = D + C;
            string showE1 = ~E1;
            Console.WriteLine(showE1);
        }
    }


    class FirstEx
    {
        public char symb;
        public FirstEx (char symb)
        {
            this.symb = symb;
        }

        public static FirstEx operator+(FirstEx obj, int x)
        {
            int temp = obj.symb + x;            
            return new FirstEx((char)temp);
        }

        public static FirstEx operator +(int x, FirstEx obj)
        {
            int temp = obj.symb + x;
            return new FirstEx((char)temp);
        }

        public static int operator-(FirstEx obj1, FirstEx obj2)
        {
            int n = obj1.symb - obj2.symb;
            return n;
        }

        public static FirstEx operator--(FirstEx obj)
        {
            obj.symb--;
            return obj;
        }

        public static FirstEx operator++(FirstEx obj)
        {
            obj.symb++;
            return obj;          
        }

        public static void FirstExs()
        {
            FirstEx A = new FirstEx('G');
            Console.WriteLine(A.symb);
            A++;
            Console.WriteLine(A.symb);
            FirstEx B = new FirstEx('L');
            Console.WriteLine(B.symb);
            B--;
            Console.WriteLine(B.symb);
            FirstEx C = new FirstEx('c');
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
