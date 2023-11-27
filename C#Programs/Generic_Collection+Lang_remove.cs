using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection_Lang_remove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> langs = new List<string>();

            langs.Add("Sujit");
            langs.Add("Ajit");
            langs.Add("Devid");
            langs.Add("Prakash");
            langs.Sort();


            foreach (string s in langs)
            {
                Console.WriteLine(s);
            }

            
            Console.WriteLine("----Lange Remove----");       

            langs.Remove("Ajit");
            langs.Remove("Prakash");
            foreach (string s in langs)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine("----insert----");

            langs.Insert(2,"mohit");
            langs.Insert(3,"adnan");
            

            foreach(string s in langs)
            {
                Console.WriteLine(s);
            }
            langs.Sort();
            Console.ReadKey();
        }
    }
}
