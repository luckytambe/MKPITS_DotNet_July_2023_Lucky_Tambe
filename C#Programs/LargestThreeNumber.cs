using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestThreeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Enter Three num");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3 ) 
            {
                Console.WriteLine("Num1 Number is the greatest among three");
            }
            else if (num2 > num3)
            {
                Console.WriteLine("num2 Number is the greatest among three");
            }
            else
            {
                Console.WriteLine("Num3 Number is the greatest among three");
            }

            Console.ReadKey();

        }
    }
}
