using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Sum_natural_Num_Example
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
                Console.WriteLine("Enter num");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + count;
                Console.WriteLine(" sum is = " + sum);
                count++;
            }
            while (count < num);
            Console.ReadKey();

        }
    }
}
