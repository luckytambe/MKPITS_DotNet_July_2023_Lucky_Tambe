using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_Collection_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList <int> li = new LinkedList<int> ();
            li.AddLast (10);
            li.AddLast (7);
            li.AddLast (11);

            LinkedListNode<int> node = li.Find(7);
            li.AddLast(6);

            foreach(int i in li)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
