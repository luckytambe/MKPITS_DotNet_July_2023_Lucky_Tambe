using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignMultiplicationOfThreeNumbers11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, Ans;
            Console.WriteLine("Enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num3");
            num3 = Convert.ToInt32(Console.ReadLine());

            Ans = num1 * num2 * num3;
            Console.WriteLine("Ans is = " + Ans);
            Console.ReadLine();

        }
    }
}
