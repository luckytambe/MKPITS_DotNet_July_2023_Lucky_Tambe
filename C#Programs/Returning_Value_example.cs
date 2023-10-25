using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Returning_Value_example
{
    internal class Program
    {
        static int factorial(int num)
        {
            int fact = 1;
            while (num > 0)
            {
                fact = fact * num;
                num--;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            int number;
            int result;
            Console.WriteLine("Enter number");
            number= Convert.ToInt32(Console.ReadLine());
            result=factorial(number);
            Console.WriteLine("Result is = " + result);
            Console.ReadKey();

        }
    }
}
