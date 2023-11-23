using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreyList_Sort_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList l = new ArrayList();
            l.Add("ravina");
            l.Add("katrina");
            l.Add("Dooja");
            l.Add("chondri");
            l.Sort();   

            foreach( object N in l )
            {
                Console.WriteLine(N);
            }
            Console.WriteLine("cpacity : " + l.Capacity);
            Console.WriteLine("Count : " + l.Count);
            Console.ReadKey();
        }
    }
}
