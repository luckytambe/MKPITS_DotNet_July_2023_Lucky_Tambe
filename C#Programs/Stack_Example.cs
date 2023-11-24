using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Stack_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack S = new Stack();
            S.Push(1);
            S.Push(2);
            S.Push(3);
            S.Push(4);
            S.Push(5);
            S.Push(6);
            S.Push(7);

            Console.WriteLine("--- Series ---");
            foreach(int i in S)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---- By Pushing numbers ----");
            S.Push(10);
            S.Push(11);
            foreach(int i in S)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---- By Removing ----");
            S.Pop();
            S.Pop();
            foreach(int i in S)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();  
        }
    }
}
