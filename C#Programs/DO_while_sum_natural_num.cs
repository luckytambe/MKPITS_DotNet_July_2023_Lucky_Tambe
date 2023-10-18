using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a C# Sharp program to find the sum of the first 10 natural numbers.
//Expected Output :
namespace DO_while_sum_natural_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter = 1;
            int sum = 0;

            Console.WriteLine("Enter num");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine(counter);
                sum = sum + counter;
                counter++;
            }
            while (counter <= num);
            Console.WriteLine("Sum is = " + sum);
            Console.ReadKey();
        }
    }
}
