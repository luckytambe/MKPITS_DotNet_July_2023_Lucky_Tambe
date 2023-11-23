using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrey_Remove_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList Ar = new ArrayList();
            Ar.Add(8);
            Ar.Add(7);
            Ar.Add(9);
            Ar.Add(1);

            Console.WriteLine("--------Arrey List-------");

            foreach( object obj in Ar )
            {
                Console.WriteLine("Number " + obj);
            }
            Ar.Insert(2, 8);

            Console.WriteLine("For Insert Method ");

            foreach( object obj in Ar )
            {
                Console.WriteLine("Insert " + obj);
            }

            Console.WriteLine(" For Remove Number ");

            Ar.Remove(8);
            foreach( object obj in Ar )
            {
                Console.WriteLine("Remove number : " + obj);
            }

            Ar.RemoveAt(3);
            Console.WriteLine("Remove Numbers : ");

            foreach (object obj in Ar)
            {
                Console.WriteLine("remove count :" + obj);
            }

            Console.WriteLine("Capacity : " + Ar.Capacity);
            Console.WriteLine("Count : " + Ar.Count);

            Console.ReadKey();
        }
    }
}
