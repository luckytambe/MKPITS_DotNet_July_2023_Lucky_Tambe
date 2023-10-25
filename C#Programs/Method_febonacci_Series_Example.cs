using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_febonacci_Series_Example
{
    internal class Program
    {
        static void Febonaaci(int n)
        {
            int num1 = 0;
            int num2 = 1;
            int add = num1 + num2;
            Console.WriteLine("{0},{1},", num1, num2);

            for (int count = 1; count <= n; count++)
            {
                Console.WriteLine("{0},", add);
                num1 = num2;
                num2 = add;
                add = num1 + num2;
            }
        }

        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number");
            num=Convert.ToInt32(Console.ReadLine());
            

            Febonaaci(num);

            Console.ReadKey();
        }
    }
}
