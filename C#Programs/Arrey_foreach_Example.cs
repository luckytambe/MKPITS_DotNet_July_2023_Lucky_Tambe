using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrey_foreach_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3,8,9 };
            int sum = 0;

                foreach (int var in arr)
            {
                Console.WriteLine(var);
                sum=sum +var;
            }
            Console.WriteLine("Sum is = " + sum);
            Console.ReadKey();
        }
    }
}
