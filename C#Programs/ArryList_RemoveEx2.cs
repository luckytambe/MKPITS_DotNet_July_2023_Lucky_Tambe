using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArryList_RemoveEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Lucky");
            ar.Add("devid");
            ar.Add("Sarang");
            ar.Add("cheaten");
            ar.Add("Akash");

            Console.WriteLine("----For Naming List----");
            foreach(object ob in ar)
            {
                Console.WriteLine("Name " + ob);
            }

            Console.WriteLine("----For one remove Name List----");
            ar.Remove("devid");
            foreach (object ob in ar)
            {
                Console.WriteLine(ob);
            }

            Console.WriteLine("---- For Remove Name Number ----");

            ar.RemoveAt(2);
            foreach(object ob in ar)
            {
                Console.WriteLine(ob);
            }

            Console.WriteLine("Capacity : " + ar.Capacity);
            Console.WriteLine("Count : " + ar.Count);
            Console.ReadKey();
        }
    }
}
