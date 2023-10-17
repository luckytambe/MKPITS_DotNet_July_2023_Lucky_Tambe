using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhilePrint_1To10_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Console.WriteLine("Enter num");
            num=Convert.ToInt32(Console.ReadLine());

            while (num < 10)
            {
                Console.WriteLine(" num is " + num);
                num++;
            }

            Console.ReadKey();
            
        }
    }
}
