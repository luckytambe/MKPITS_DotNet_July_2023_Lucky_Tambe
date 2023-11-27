using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_collection_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> langs = new List<string>();
            langs.Add("Rakesh");
            langs.Add("mukesh");
            langs.Add("Sukesh");
            langs.Add("naresh");

           

            foreach (string s in langs)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(langs.Count);
            
            Console.ReadKey();
        }
    }
}
