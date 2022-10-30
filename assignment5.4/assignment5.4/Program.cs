using System;
using System.Collections;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;
namespace AStack
{
    internal class Program
    {
        public static void Main(String[] args)
        {

            MyStack myStack = new MyStack();
            myStack.Pop();
            myStack.PrintStack();
            //Console.WriteLine(" poped Element {0}",myStack.Pop

        }
    }
}
