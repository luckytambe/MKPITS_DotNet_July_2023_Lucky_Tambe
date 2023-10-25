using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto_Example_Even_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0) goto Even;
            Console.WriteLine("Odd");
            goto end;
        Even:
            Console.WriteLine("It is even");
        end:
            Console.WriteLine("Bye");

            Console.ReadKey();
        }
    }
}
