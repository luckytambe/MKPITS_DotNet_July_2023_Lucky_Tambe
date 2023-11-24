using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Stack_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack sc = new Stack();
            sc.Push(1);
            sc.Push(2);
            sc.Push(3);
            sc.Push(4);

            foreach( int i in sc)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            sc.Push(8);
            sc.Push(10);
            Console.WriteLine("Adding Elements" + sc.Peek());
            foreach( int i in sc)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Removing Stack");

            sc.Pop();
            sc.Pop();  
            
            foreach( int i in sc)
            {
                Console.WriteLine(i);
            }


            Console.ReadKey();
        }
    }
}
