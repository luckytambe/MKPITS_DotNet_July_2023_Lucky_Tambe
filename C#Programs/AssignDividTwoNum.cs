using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivingTwoNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, divide;
            Console.WriteLine("Enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            divide = num1 / num2;
            Console.WriteLine("Divide = " + divide);
            Console.ReadKey();
        }
    }
}
