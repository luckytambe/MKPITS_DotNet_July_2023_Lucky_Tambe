using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Key_value_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "Devid");
            ht.Add("2", "sarang");
            ht.Add("3", "cheatan");
            ht.Add("4", "Akash");
            ht.Add("5", "sujit");

            if(ht.ContainsValue("Lucky"))
            {
                Console.WriteLine("Already Exists");
            }
            else
            {
                ht.Add("6", "Lucky");
            }

            ICollection ht2 = ht.Keys;

            foreach(object ob in ht2)
            {
                Console.WriteLine(ob + " " + ht[ob]);
            }

            Console.ReadKey();
        }
    }
}
