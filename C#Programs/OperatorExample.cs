using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            Console.WriteLine("Enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            result = num1 + num2;
            Console =.Writeline("Result = " + result);

            result = num1 - num2;
            Console =.Writeline("Result = " + result);

            result = num1 * num2;
            Console =.Writeline("Result = " + result);

            result = num1 / num2;
            Console =.Writeline("Result = " + result);

            Console.ReadKey();

        }
    }
}
5
