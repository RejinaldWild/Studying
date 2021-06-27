using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] a = new[] { "World", "of", "Warcraft" };
            //string ab = "World";
            //string b = " of ";
            //string c = "Warcraft";
            //string d = String.Concat(ab, b, c);            
            //b =String.Join(" ",a);
            //Console.WriteLine(d);
            //Console.WriteLine(b);
            //string strr = GetReversed(b);
            //Console.WriteLine(strr);
            //String A = "Mir Warcrafta";

            //1
            //string str = StringToSpaceString("Test number 1");
            //Console.WriteLine(str);
            //Console.WriteLine();

            //2
            //string str = ReverseString("you love I");
            //Console.WriteLine(str);
            //Console.WriteLine();

            //3
            //Console.WriteLine(CompareStrings("123a", "214b"));
            //Console.WriteLine(CompareStrings("123", "123c"));
            //Console.WriteLine(CompareStrings("123", "125"));

            //4
            // Collections/Hash
            //Console.WriteLine(CompareStr("ababb", "Ab"));
            //Console.WriteLine(CompareStr("bca", "aacBd"));
            //Console.WriteLine(CompareStr("abccCa", "cba"));
            //Console.WriteLine(CompareStr("bca", "aBb"));

            //5
            //int[] arr = FindSymbol("World of Warcraft", 'w');           
            //ShowArray(arr);                        

            //7
            //Console.WriteLine(PartString("Massives are impossible", 8 , 22));

            //8
            //EightClass SubStr = new EightClass("It is test for learning C#!");
            //string str = SubStr.Ins("Ha-Ha111111111111111111111111111111111111111111111111111", 2);
            //string str1 = SubStr.ToString();
            //Console.WriteLine(str);
            //Console.WriteLine(str1);

            //9

            //NinthClass Splitmir = new NinthClass("I love you World of Warcraft", ' ');
            //string[] str = Splitmir.ArrStr();
            //string txt = Splitmir.ToString();
            //Console.WriteLine(txt);


            //10
            //TenthClass TenExc = new TenthClass(20, 0, 10);
            //TenExc.ToString();

            //6
            //string str = "fA,sa.Dg!k s?dj";
            //Console.WriteLine(str);
            //char[] arr = StringToAlphabet(str);
            //ShowArray(arr);
            //string str1 = "It isn't interesting. To try test! All commas, dots etc. Right?";
            //Console.WriteLine(str1);
            //char[] arr1 = StringToAlphabet(str1);
            //ShowArray(arr1);            
        }

        //6
        static public char[] StringToAlphabet(string text)
        {
            text = text.ToUpper();
            int index=0;            
            int[] count = new int[26];
            for(int i = 0; i < count.Length; i++)
            {
                count[i] = 0;
            }
            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] - 'A'>= 0 && text[i]-'Z'<=26)
                {
                    count[text[i] - 'A'] = 1;                    
                }                
            }
            
            char[] temp = new char[26];
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] == 1)
                {
                    temp[i] = (char)(count[i] - 1 + ('A' + i));
                }
            }            
            return temp;
        }
        static public void ShowArray(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }

        //4
        static public bool CompareStr(string a, string b)
        {
            int[] count = new int[26];
            for (int i = 0; i < count.Length; i++)
            {
                count[i] = 0;
            }
            a = a.ToLower();
            b = b.ToLower();
            for (int i = 0; i < a.Length; i++)
            {
                count[a[i] - 'a'] = 1;
            }
            for (int i = 0; i < b.Length; i++)
            {
                if (count[b[i] - 'a'] != 1)
                {
                    return false;
                }
            }
            for (int i = 0; i < count.Length; i++)
            {
                count[i] = 0;
            }
            for (int i = 0; i < b.Length; i++)
            {
                count[b[i] - 'a'] = 1;
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (count[a[i] - 'a'] != 1)
                {
                    return false;
                }
            }
            return true;
        }
        

        //9
        static public void ShowArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+'|');
            }
            Console.WriteLine();
        }

        //7
        static public string PartString (string text, int startIndex, int endIndex)
        {
            string substring="";
            if(endIndex>text.Length || startIndex < 0)
            {
                return "Please,try again later";
            }
            for(int i = startIndex; i < endIndex; i++)
            {
                substring += text[i].ToString();
            }
            return substring;
        }

        //5
        static public int[] FindSymbol(string text, char symb)
        {
            int index = 0;
            int count = 0;
            int[] temp = new int[text.Length];
            index = text.IndexOf(symb, index);
            while (index != -1)
            {
                temp[count] = index;
                count++;
                index = text.IndexOf(symb, index + 1);
            }

            if (count == 0)
            {
                return new int[] { -1 };
            }

            int[] arr = new int[count];
            for (int i = 0; i < count; i++)
            {
                arr[i] = temp[i];
            }
            return arr;
        }
        static public void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
        }

        //3

        static public bool CompareStrings (string a, string b)
        {
            if (a.Length != b.Length) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if(Math.Abs(a[i] - b[i]) > 1)
                {
                    return false;
                }                
            }
            return true;            
        }

        //2
        static public string ReverseString(string a)
        {
            string temp="";
            string[] lines = a.Split();
            for(int i = 0; i <lines.Length ; i++)
            {
                temp = lines[i]+" "+temp;
            }
            return temp;
        }

        //1
        static public string StringToSpaceString (string a)
        {            
            string temp = "";
            for (int i = 0; i < a.Length; i++)
            {
                temp = temp + a[i] + " ";
            }
            return temp;
        }

        static string GetReversed(string a)
        {
            string str = "";
            foreach(char s in a)
            {
                str = s + str;
            }
            return str;
        }
    }
}
