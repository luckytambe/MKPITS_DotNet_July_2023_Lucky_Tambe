using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_While_1to5_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 111;

            do
            {
                Console.WriteLine(" num is {0}", num);
                num++;
            }
            while (num <= 80);
            {
                Console.WriteLine("Bye");
               
            }
            Console.ReadKey();
        }
    }
}
