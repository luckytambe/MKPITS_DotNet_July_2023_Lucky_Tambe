using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList_Collection_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> la = new LinkedList<string>();
            la.AddLast("a");
            la.AddLast("d");
            la.AddLast("z");
            la.AddLast("r");

            LinkedListNode<string> nodel = la.Find("d");
            la.AddBefore(nodel,"p");

            foreach(string s in la)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
