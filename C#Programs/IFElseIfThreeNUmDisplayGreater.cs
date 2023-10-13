using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFElseIfThreeNUmDisplayGreater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter three num");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2 && num1 >num3)
            {
                Console.WriteLine("num 1 is grater ");
            }
            else if ( num2 > num3)
            {
                Console.WriteLine("Num 2 is greater ");
            }
            else
            {
                Console.WriteLine("Num3 is grater ");
            }

            Console.ReadKey();
        }
    }
}
