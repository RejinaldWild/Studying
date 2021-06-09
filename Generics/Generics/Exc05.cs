using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MyClassExc05<T> // Node<T> or Joint<T>
    {
        public T Data { get; set; }
        public MyClassExc05<T> Next { get; set; }
        public MyClassExc05(T data)
        {
            Data = data;
        }
    }

    internal class MyClassExc05LinkedList<T> //LinkedList
    {
        MyClassExc05<T> Head;
        MyClassExc05<T> Tail;
        int counter;
        
        public void Add(T data)
        {
            MyClassExc05 <T> Node = new MyClassExc05<T>(data);
            if (Head == null)
            {
                Head = Node;
            }
            else
            {   
                Tail.Next = Node;
            }
            Tail = Node;
            counter++;
        }

        public void ShowNumberObjects()
        {
            Console.WriteLine(counter);
        }

        public bool Contains(T data)
        {
            MyClassExc05<T> Current = Head;
            while (Current != null)
            {
                if (Current.Data.Equals(data))
                {
                    Console.WriteLine(true);
                    return true;
                }
                Current = Current.Next;
            }
            Console.WriteLine(false);
            return false;
        }

        public void Remove(T data)
        {
            MyClassExc05<T> Current = Head;
            MyClassExc05<T> Previous=null;
            while (Current != null)
            {
                if (Current.Data.Equals(data))
                {
                    if (Previous != null)
                    {
                        Previous.Next = Current.Next;
                        if (Current.Next == null)
                        {
                            Tail = Previous;
                        }
                    }
                    else
                    {
                        Head = Head.Next;
                        if (Head == null)
                        {
                            Tail = null;
                        }
                        
                    }
                    counter--;
                }
                Previous = Current;
                Current = Current.Next;
            }
        }
    }

    internal class Exc05
    {
        public static void MainExc05()
        {
            MyClassExc05LinkedList<int> A = new MyClassExc05LinkedList<int>();
            A.Add(13);
            A.Add(8);
            A.Add(88);
            A.Add(44);
            A.Add(18);
            A.ShowNumberObjects();
            A.Remove(88);
            A.ShowNumberObjects();
            A.Remove(2);
            A.ShowNumberObjects();
            A.Contains(13);
            A.Remove(13);
            A.Remove(18);
            A.ShowNumberObjects();
            A.Contains(13);
            A.Contains(44);
        }
    }
}
