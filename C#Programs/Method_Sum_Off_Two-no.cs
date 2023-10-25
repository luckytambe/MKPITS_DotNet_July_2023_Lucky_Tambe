using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Sum_Off_Two_no
{
    internal class Program
    {
        static void Add( int num1, int num2)
        {
             int result = 0;
            result = num1 + num2;
            Console.WriteLine("result = " + result);
        }
        static void Main(string[] args)
        {
            int num1, num2;
            int Sum ;
            Console.WriteLine("Enter Num1");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2");
            num2=Convert.ToInt32(Console.ReadLine());

            Add(num1,num2);

            Console.ReadKey();

        }
    }
}
