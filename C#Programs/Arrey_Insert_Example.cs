using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrey_Insert_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Lucky");
            ar.Add("sami");
            ar.Add("Saku");
            ar.Add("moku");
            ar.Sort();

            foreach ( object obj in ar)
            {
                Console.WriteLine( "Name : " + obj);
            }

            ar.Insert(3, "Tambe");
            Console.WriteLine("capacity : " + ar.Capacity);
            Console.WriteLine("Count : " + ar.Count);

            Console.WriteLine("For Insert Method");
            foreach( object obj in ar)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();
        }
    }
}
