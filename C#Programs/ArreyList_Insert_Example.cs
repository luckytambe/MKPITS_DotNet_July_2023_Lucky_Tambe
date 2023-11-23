using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreyList_Insert_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(1);
            a.Add(2);
            a.Add(3);

            foreach ( object o in a )
            {
                Console.WriteLine("list arrey " + o);
            }
            a.Insert(3 , 17);

            Console.WriteLine("array list colection after adding element);

            foreach( object o in a )
            {
                Console.WriteLine("Second list " + o);
            }

            Console.ReadKey();
        }
    }
}
