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
            char op;
            Console.WriteLine("Enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Op ( +,-,/,* )");
            op = Convert.ToInt32(Console.ReadLine());

            result = Convert.ToInt32(Console.ReadLine());

            switch (op)

        {
                case '+':
            result = num1 + num2;
            break;

                case '-':
             result = num1 - num2;
            break;

                case '*':
                    result = num1 * num2;
            break;

                case '/':
                    result = num1 / num2;
            break;
                    
                    
        }
            Console.WriteLine("Result is = " + result);
            Console.ReadKey();


        }
    }
}
