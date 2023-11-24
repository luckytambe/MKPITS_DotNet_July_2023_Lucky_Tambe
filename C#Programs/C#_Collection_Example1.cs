using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace C__Collection_Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable Ha= new Hashtable();
            Ha.Add(1, "Akash");
            Ha.Add(2, "Chetan");
            Ha.Add(3, "Devid");
            Ha.Add(4, "lucky");
            Ha.Add(5, "sarang");

            foreach(object s in Ha.Keys)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine(); 
        }
    }
}
