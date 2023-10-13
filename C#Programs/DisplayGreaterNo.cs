using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayGreaterNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Num1 is greater ");
            }
            else
            {
                Console.WriteLine("Num2 is greater then num1");
            }

            Console.ReadKey();
        }
    }
}
