using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArreyList_count_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(5);
            a.Add(9);
            a.Add(3);
            a.Add(8);
            a.Add(1);
            a.Add(2);
            
            foreach (object obj in a)
            {
               
                Console.WriteLine("number is : " + obj);
            }
            
            Console.WriteLine("capacity : " + a.Capacity);
            Console.WriteLine("Count : " + a.Count);


            Console.ReadKey();
        }
    }
}
