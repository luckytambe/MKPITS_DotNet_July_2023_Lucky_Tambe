using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//wap to accept a number and print whether no .is prime or not
namespace For_Prime_Or_Not_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int counter;
            int flag = 0;
            Console.WriteLine("Enter num");
            number=Convert.ToInt32(Console.ReadLine());
            for ( counter = 2; counter < number; counter++) 
            {
                if (number % 2== 0)  
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("It is prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }

            Console.ReadKey();

        }
    }
}
