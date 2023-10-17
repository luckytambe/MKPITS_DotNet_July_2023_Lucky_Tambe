using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignWhile_1To_10SumExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num ;
            int count = 1;
            int sum = 0;

            Console.WriteLine("Enter Num");
            num=Convert.ToInt32(Console.ReadLine());

            while( count < num)
            {
                Console.WriteLine(count);
                sum = sum + count; 
                count++;
         
            }
            Console.WriteLine("Sum is = " + sum);
            Console.ReadKey();
        }
    }
}
