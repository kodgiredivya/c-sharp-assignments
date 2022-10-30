using System;

namespace AStack
{
    internal class Program
    {
        public static void Main(String[] args)
        {

            MyStack myStack = new MyStack();
            myStack.Push(20);
            myStack.Push(40);
            myStack.Push(30);
            myStack.PrintStack();
            var temp=myStack.Pop();
            Console.WriteLine("popped element = {0}" , temp);
            myStack.PrintStack();
            myStack.Pop();
        }
    }
}

