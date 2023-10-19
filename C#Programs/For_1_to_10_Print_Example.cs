using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////wap to print 1 to 10 using for loop
namespace For_1_to_10_Print_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int Counter= 1; Counter <=10; Counter ++)
            { 
                Console.WriteLine(Counter);
            }
            Console.ReadKey();
        }
    }
}
