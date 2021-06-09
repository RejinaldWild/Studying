using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different
{
    internal class StackQueue
    {
        public static void Show(ICollection s)
        {
            Console.WriteLine("Collection elements:");
            foreach(object obj in s)
            {
                Console.Write("|"+obj);
            }
            Console.WriteLine("|");
        }
    }

    internal class Listing11
    {
        public static void MainListing11()
        {
            Stack MyStack = new Stack();
            MyStack.Push("First");
            MyStack.Push("Second");
            MyStack.Push("Third");
            StackQueue.Show(MyStack);
            Console.WriteLine("Read: "+MyStack.Peek());
            StackQueue.Show(MyStack);
            Console.WriteLine("Pop up: "+MyStack.Pop());
            StackQueue.Show(MyStack);

            Queue MyQueue = new Queue();
            MyQueue.Enqueue("One");
            MyQueue.Enqueue("Two");
            MyQueue.Enqueue("Three");
            StackQueue.Show(MyQueue);
            Console.WriteLine("Read: " + MyQueue.Peek());
            StackQueue.Show(MyQueue);
            Console.WriteLine("Pop up: " + MyQueue.Dequeue());
            StackQueue.Show(MyQueue);
        }
    }
}
