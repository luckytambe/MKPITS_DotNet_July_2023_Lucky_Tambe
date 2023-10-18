using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_example_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            int count = 1;

                
            do
            {
                Console.WriteLine(count);
                sum = sum + count;               
                count++;
            }
            while ( count <= 7);
            Console.WriteLine("sum is = " + sum);
            Console.ReadKey();
        }
    }
}
