using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquationEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            float result = 0;

            Console.WriteLine("Enter a ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            result = b * b - 4 * a * c;

            if (result!=0)
            {
                Console.WriteLine("Roots Are Imaganary");
            }
            else
            {
                Console.WriteLine("Roots Are real");
            }
            Console.ReadKey();

        }
    }
}
