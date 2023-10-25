using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Swap_Example
{
    internal class Program
    {
        static void swap(int a , int b)
        {
            a= a - b;
            b = a + b;
            a = b - a;

            Console.WriteLine("Now the 1st number is : {0}, and the 2nd number is {1}", b, a);
        }
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Enter Number1");
            a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number2");
            b=Convert.ToInt32(Console.ReadLine());

            swap(a, b);

            Console.ReadKey();
        }
    }
}
