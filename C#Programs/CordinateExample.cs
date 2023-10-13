using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatioExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Enter n1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter n1");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 > 0 && num2 > 1)
            {
                Console.WriteLine("The coordinate point ({0},{1}) lies in the First quadrant.", num1, num2 );
            }
            else if (num1 < 0 && num2 > 1)
            {
                Console.WriteLine("The coordinate point ({0},{1}) lies in the Second quadrant.", num1, num2);
            }
            else if (num1 < 0 && num2 < 1)
            {
                Console.WriteLine("The coordinate point ({0},{1}) lies in the Third quadrant.", num1, num2);
            }
            else if (num1 > 0 && num2 < 1)
            {
                Console.WriteLine("The coordinate point ({0},{1}) lies in the Forth quadrant.", num1, num2);
            }
            Console.ReadKey();

        }
    }
}
