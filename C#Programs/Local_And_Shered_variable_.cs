using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_And_Shered_variable_
{
    internal class Program
    {

        static int num1 = 20;

        static void Calculate()
        {
            int num = 10;
            Console.WriteLine("Input value is = " + num);
        }
        static void Main(string[] args)
        {
            Calculate();
            Console.WriteLine("Output value is = " + num1);
            Console.ReadKey();

        }
    }
}
