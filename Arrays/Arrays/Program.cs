using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //Console.WriteLine("Input number element of array");
            //try
            //{
            //    int c = Convert.ToInt32(Console.ReadLine());
            //    int[] array = new int[c];
            //    int counter = 0;
            //    int i = 0;
            //    while (counter < array.Length)
            //    {
            //        if (i % 5 == 2)
            //        {
            //            array[counter] = i;
            //            counter++;
            //            Console.Write("{0}\t", i);
            //        }
            //        i++;
            //    }

            //for (i = 0; counter < array.Length; i++)
            //{
            //    if (i % 5 == 2)
            //    {
            //        array[counter] = i;
            //        Console.Write("{0}\t", i);
            //        counter++;
            //    }
            //}
            //}
            //catch
            //{
            //    Console.WriteLine("Number is incorrect!");
            //}


            //2
            //int eleven = 11;
            //int[] array = new int[eleven];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = (int)Math.Pow(2, i);
            //    Console.Write($"{array[i]}\t");
            //}
            //Console.WriteLine();
            //int temp;
            //for(int i = array.Length-1; i >= 0; i--)
            //{
            //    Console.Write($"{array[i]}\t");
            //}

            //Отзеркаливание массива

            //for (int i = 0; i < eleven / 2; i++)
            //{
            //    temp = array[i];
            //    array[i] = array[eleven - i - 1];
            //    array[eleven - i - 1] = temp;
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"{array[i]}\t");
            //}

            //3
            //int ten = 10;
            //char[] charArray = new char[ten];
            //char a = 'a';                       
            //for(int i = 0; i < charArray.Length; i++)
            //{
            //    charArray[i] =(char)(a+2*i);                
            //    Console.Write("{0}\t",charArray[i]);
            //}
            //Console.WriteLine();
            //char temp = '0';
            //for(int i =0; i < charArray.Length/2; i++)
            //{
            //    temp = charArray[i];
            //    charArray[i] = charArray[ten - i - 1];
            //    charArray[ten - i - 1] = temp;                
            //}
            //for(int i=0; i < charArray.Length; i++)
            //{
            //    Console.Write("{0}\t", charArray[i]);
            //}

            //4

            //char[] arrayLetter = new char[10];
            //int counter = 0;
            //char s = 'A';
            ////arrayLetter[0] = s;
            //int i = 0;
            //while (counter < arrayLetter.Length)
            //{
            //    char letter = (char)(s + i);
            //    if (letter == 'A' || letter == 'E' || letter == 'I')
            //    {
            //        i++;
            //        continue;
            //    }
            //    else
            //    {
            //        arrayLetter[counter] = letter;
            //        counter++;
            //        i++;
            //    }
            // }         
            //for (int j = 0; j < arrayLetter.Length; j++) { Console.Write($"{arrayLetter[j]}"); }

            //5

            //Random rnd = new Random();
            //int[] rnum = new int[15];
            //int value = 9;
            //for (int i = 0; i < rnum.Length; i++)
            //{
            //    rnum[i] = rnd.Next(0, 9);
            //    Console.Write("{0}\t", rnum[i]);
            //}
            //Console.WriteLine();

            //for (int j = 0; j <rnum.Length; j++)
            //{
            //    if (value > rnum[j])
            //    {                   
            //        value = rnum[j];                                       
            //    }
            //}
            //for (int j = 0; j < rnum.Length; j++)
            //{
            //    if (value==rnum[j])
            //    {                    
            //        Console.WriteLine("Min index = {0}", j);
            //    }
            //}            
            //Console.WriteLine("Min value = {0}", value);

            //6

            //Random rnd = new Random();
            //int[] arr = new int[10];
            //for(int i=0; i<arr.Length; i++)
            //{
            //    arr[i] = rnd.Next(0, 9);
            //    Console.Write("{0}\t",arr[i]);
            //}
            //Console.WriteLine();
            //int temp = 0;
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    for(int j = 0; j<arr.Length-1;j++)
            //    if (arr[j] < arr[j + 1])
            //    {
            //        temp = arr[j];
            //        arr[j] = arr[j + 1];
            //        arr[j + 1] = temp;
            //    }                
            //}
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("{0}\t", arr[i]);
            //}
            //Console.WriteLine();

            //7
            //char[] arrc = new char[]{ 'R','2','D','S','5','6' };
            //int counter = 0;
            //for(int i = 0; i < arrc.Length; i++)
            //{
            //    counter++;
            //}
            //for (int i = 0; i < arrc.Length; i++)
            //{
            //    Console.Write($"{arrc[i]}");
            //}
            //Console.WriteLine();
            //char temp = '0';
            //for(int i = 0; i < arrc.Length/2; i++)
            //{
            //    temp = arrc[i];
            //    arrc[i] = arrc[counter - i - 1];
            //    arrc[counter - i - 1] = temp;
            //}
            //for(int i = 0; i < arrc.Length; i++)
            //{
            //    Console.Write($"{arrc[i]}"); 
            //}
            //Console.WriteLine();

            //8
            //int temp,row = 3, col = 5;
            //int[,] arr = new int[row,col];
            //Random rnd = new Random();
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for(int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = rnd.Next(0, 15);
            //        Console.Write($"{arr[i,j]}\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //int[,] atemp = new int[arr.GetLength(0)+2,arr.GetLength(1)-2];

            //for (int i = 0; i < atemp.GetLength(0); i++)
            //{
            //    for (int j = 0; j < atemp.GetLength(1); j++)
            //    {
            //        atemp[i, j] = arr[j, i];
            //        Console.Write("{0}\t", atemp[i, j]);
            //    }
            //    Console.WriteLine();
            //}    

            //9
            //int row = Convert.ToInt32(Console.ReadLine());
            //int col = Convert.ToInt32(Console.ReadLine());
            //int[,] arr = new int[row,col];
            //Random rnd = new Random();
            //int counter = 1;
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for(int j = 0; j<arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = counter;
            //        counter++;
            //        Console.Write("{0}\t",arr[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            //int[,] arr1 = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];

            //int rndrow = rnd.Next(arr1.GetLength(0));
            //int rndcol = rnd.Next(arr1.GetLength(1));
            //Console.WriteLine(rndrow);
            //Console.WriteLine(rndcol);
            //int a, b; //index for second array
            //for (int i =0; i<arr1.GetLength(0); i++)
            //{
            //    if (i >= rndrow) a = i+1;
            //    else a = i;
            //    for(int j=0; j<arr1.GetLength(1); j++)
            //    {
            //        if (j >= rndcol) b = j+1;
            //        else b = j;
            //        arr1[i, j] = arr[a, b];
            //        Console.Write("{0}\t",arr1[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            //10

            int[] array = new int[2];
            RefMeth(array);


            int row = Convert.ToInt32(Console.ReadLine());
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[row, col];
            int counter = 1;           
            
            for (int layer = 0; layer <(arr.GetLength(0)/2) ; layer++)
            {
                for (int j = layer; j < arr.GetLength(1)-layer; j++)
                {
                    arr[layer, j] = counter;
                    counter++;                    
                }
                for (int j = layer+1; j< arr.GetLength(0)-1-layer; j++)
                {
                    arr[j,arr.GetLength(1)-1-layer] = counter;
                    counter++;
                }
                for (int j = layer; j < arr.GetLength(1) - layer; j++)
                {
                    arr[arr.GetLength(0)-1-layer, arr.GetLength(1)-j-1] = counter;
                    counter++;
                }
                //for (int j = arr.GetLength(1)-layer-1; j >= layer; j--)
                //{
                //    arr[arr.GetLength(0)-1-layer, j] = counter;
                //    counter++;
                //}                
                for (int j = arr.GetLength(0) - 2-layer; j > layer; j--)
                {
                    arr[j, layer] = counter;
                    counter++;
                }                
            }

            if (row % 2 != 0 && col % 2 != 0)
            {
                arr[arr.GetLength(0)/2,arr.GetLength(1)/2] = counter;
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j =0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0}\t", arr[i, j]);
                }
                Console.WriteLine();
            }
            
        }

        public static void RefMeth(int[] a)
        {
            a = null;
        }
    }
}
