using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coolection_Values_Keys_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "sarang");
            ht.Add("2", "devid");
            ht.Add("3", "Aaksh");
            ht.Add("4", "chetan");
            ht.Add("5", " sujit");

            if (ht.ContainsValue("Sujit"))
            {
                Console.WriteLine("This Name is already exists in list");
            }

            else
            {
                ht.Add("6","sujit");
            }

            ICollection co = ht.Keys;

            foreach (string o in co)
            {
                Console.WriteLine(o + " : " + ht[o]);
            }

            Console.ReadKey();
        }
    }
}
