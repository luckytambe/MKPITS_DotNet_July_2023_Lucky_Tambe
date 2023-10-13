using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter Year");
            num = Convert.ToInt32(Console.ReadLine());

            if (num%4==0)
            {
                Console.WriteLine("It is Leap Year");
            }
            else
            {
                Console.WriteLine("It is not Leap ");
            }

            Console.ReadKey();
        }
    }
}
