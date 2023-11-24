using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SortedList_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add(1, "Devid");
            sl.Add(8, "choman");
            sl.Add(7, "Gutta");
            sl.Add(11, "chetan");

            if(sl.ContainsValue("45"))
            {
                Console.WriteLine("Already In list ");
            }
            else
            {
                sl.Add(45,"lucky");
            }

            ICollection key = sl.Keys;
            foreach (int ke in key)
            {
                Console.WriteLine(ke + " : " + sl[ke]);
            }
            Console.ReadKey();
        }
    }
}
