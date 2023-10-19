using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Table_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            Console.WriteLine("Enter number");
            number=Convert.ToInt32(Console.ReadLine());

            for (int counter = 1; counter<=10; counter++)
            {

                sum = number * counter;
                Console.WriteLine(" {0} x {1} = {2} ", number, counter, sum);
            }
            
            Console.ReadKey();
        }
    }
}
