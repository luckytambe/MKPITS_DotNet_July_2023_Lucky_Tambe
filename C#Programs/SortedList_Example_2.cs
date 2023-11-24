using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace SortedList_Example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            SortedList s = new SortedList();
            s.Add(5, "Devid");
            s.Add(4, "Akash");
            s.Add(2, " Akash");
            s.Add(8, "chetan");

            if(s.ContainsValue("Lucky"))
            {
               Console.WriteLine("Already");
            }
            else
            {
                s.Add(13, "bhut");
            }

            ICollection K = s.Keys;
            foreach(int ke in K)
            {
                Console.WriteLine(ke + "  " + s[ke]) ;
            }
            Console.ReadKey();
        }
    }
}
