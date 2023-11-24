using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Keys_Values_example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "Sarang");
            ht.Add("2", "devid");
            ht.Add("3", "akash");
            ht.Add("4", "chetan");
            ht.Add("5", "sujit");

            if(ht.ContainsValue("lucky"))
            {
                Console.WriteLine("It is Already Exists In list");
            }
            else
            {
                ht.Add("6", "Lucky");
            }

            ICollection ht2 = ht.Keys;
            foreach (string k in ht2)
            {
                Console.WriteLine(k + " " + ht[k]);
            }

            Console.ReadKey();  
        }
    }
}
