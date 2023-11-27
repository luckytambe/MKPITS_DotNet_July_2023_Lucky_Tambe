using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishnary_Key_value_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string , string > dic = new Dictionary<string , string>();
            dic.Add("lu", "tambe");
            dic.Add("su", "sujit");
            dic.Add("AA", "Akash");

           List<string> key = new List<string>(dic.Keys);
            Console.WriteLine("---- Key ----");
            foreach(string k in key)
            {
                Console.WriteLine("key: " + k );
            }

            Console.WriteLine("---- value ----");
            List<string> val = new List<string>(dic.Values);
            foreach (string k in val)
            {
                Console.WriteLine("Value: " + k );
            }

            Console.WriteLine("--- key value ---");
            foreach(KeyValuePair<string, string> kv in dic)
            {
                Console.WriteLine("Key : " + kv.Key + kv.Value );
            }

            Console.WriteLine("Count : " + dic.Count);
            Console.ReadKey();
        }
    }
}
