using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumTwoNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;
            Console.WriteLine("Enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;
            Console.WriteLine("sum = " + sum);
            Console.ReadKey();
        }
    }
}
