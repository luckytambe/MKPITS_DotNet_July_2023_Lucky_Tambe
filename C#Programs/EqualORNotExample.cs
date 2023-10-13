using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualORNotExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Enter Num1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Num1 : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1==num2)
            {
                Console.WriteLine("Its Equal");
            }
            else
            {
                Console.WriteLine("Its not Equal");
            }

            Console.ReadLine();

        }
    }
}
