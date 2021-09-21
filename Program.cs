using System;
using System.Collections.Generic;

namespace MyQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack
            Stack<int> stack = new Stack<int>();
            stack.Push(9);
            stack.Push(5);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());

            //Stack 2
            ClassStack<int> classstack = new ClassStack<int>();
            classstack.Push(9);
            classstack.Push(6);
            Console.WriteLine(classstack.Pop());
            Console.WriteLine(classstack.Peek());

            //Queue 2
            ClassQueue<int> queue = new ClassQueue<int>();
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(8);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());

            //Queue
            Queue<int> l = new Queue<int>();
            l.Enqueue(3);
            l.Enqueue(2);
            l.Enqueue(3);
            Console.WriteLine(l.Dequeue());
            Console.WriteLine(l.Peek());

            //Hashtable
            MyHashtable<string> test1 = new MyHashtable<string>(50);
            test1.Add("Большой");
            Console.WriteLine(test1.Search("Большой"));
        }
    }
}
