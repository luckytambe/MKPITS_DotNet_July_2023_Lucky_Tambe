using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> nums = new LinkedList<int>();

            nums.AddLast(1);
            nums.AddLast(5);
            nums.AddLast(2);
            nums.AddLast(17);
            nums.AddLast(15);


            LinkedListNode<int> node = nums.Find(5);
            nums.AddAfter(node, 10);

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
