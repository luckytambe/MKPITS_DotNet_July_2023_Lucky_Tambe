using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//wap to accept a number and print factorial
namespace For_Factorial_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int fact = 1;
            Console.WriteLine("Enter Number");
            number=Convert.ToInt32(Console.ReadLine());

            for (int counter = 1; counter <= number; counter++)
            {
                fact = fact * counter ;
                
            }
            Console.WriteLine("Fact is = " + fact);
            Console.ReadKey();
        }
    }
}
