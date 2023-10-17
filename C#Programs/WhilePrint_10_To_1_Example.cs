using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhilePrint_10_To_1_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num =1 ;
            Console.WriteLine("Enter num");
            num=Convert.ToInt32(Console.ReadLine());

            while(num>10)
            {
                Console.WriteLine("Num is = " + num);
                num--;
            }
            Console.ReadKey();
        }
    }
}
