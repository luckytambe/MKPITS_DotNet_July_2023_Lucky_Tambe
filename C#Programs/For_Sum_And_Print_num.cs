using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//wap to accept 5 no. and print the sum of 5 no.
namespace For_Sum_And_Print_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            Console.WriteLine("Enter num");
            number=Convert.ToInt32(Console.ReadLine()); 

            for(int counter=1; counter <= number; counter++)
            {
                Console.WriteLine(counter);
                sum = sum + counter;
               
            }
            Console.WriteLine(" Sum is = " + sum);
            Console.ReadKey();

        }
    }
}
