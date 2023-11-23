using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_ArryList_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList A1 = new ArrayList(); 
            A1.Add(1);
            A1.Add(2);
            A1.Add(3);
            A1.Add(4);
            Console.WriteLine("------Arrey List-------");
            foreach (Object ob in A1)
            {
               
                Console.WriteLine(ob);
            }

            A1.Remove(3);
            Console.WriteLine("------Arrey List  removing thoes number-------");
            foreach (Object ob in A1)
            {
                
                Console.WriteLine(ob);
            }

            A1.RemoveAt(2);
            Console.WriteLine("------Arrey List  removing thoes number who start from 0 -------");
            foreach (Object ob in A1)
            {
                
                Console.WriteLine(ob);
            }

            Console.ReadKey();
        }
    }
}
