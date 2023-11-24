using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Stack_Example_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack();
            s1.Push("Lucky");
            s1.Push("Devid");
            s1.Push("Sarang");

            Console.WriteLine("---- Naming List ----");
            foreach( string ch in s1)
            {
                Console.WriteLine(ch);
            }

            Console.WriteLine("---- push name List ----");
            s1.Push("Akash");
            s1.Push("Sujit");
            Console.WriteLine("Peek " + s1.Peek());
            foreach(string ch in s1)
            {
                Console.WriteLine(ch);
            }

            Console.WriteLine("---- pop name List ----");
            s1.Pop();
            foreach( string ch in s1)
            {
                Console.WriteLine(ch);
            }

            Console.ReadKey();  
        }
    }
}
