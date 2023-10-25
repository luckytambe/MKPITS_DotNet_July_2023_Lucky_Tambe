using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Returning_Op_Example
{
    internal class Program
    {
        static int calculate( int num1 , int num2 , char op)
        {
            int result = 0;
            if (op == '+')
            {
                result= num1+ num2;
            }
            else if (op=='-')
            {
                result=num1-num2;
            }
            else if (op=='*')
            {
                result = num1 * num2;
            }
            else if (op=='/')
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            return result;
        }
        static void Main(string[] args)
        {
            int sum ;
            int num1, num2;
            char op;

            Console.WriteLine("Enter num1");
                num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
                num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter op");
            op=Convert.ToChar(Console.ReadLine());

            sum = calculate(num1, num2, op);

            Console.WriteLine("Sum = " + sum);

            Console.ReadKey();
        }
    }
}
