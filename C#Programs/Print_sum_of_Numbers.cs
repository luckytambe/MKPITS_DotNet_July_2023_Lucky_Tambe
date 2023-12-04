using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_sum_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int i = 0;

            if(i < 5)
            {
                
                sum = sum + num[i];
                i++;
                
            }
            if(i == 5)
            {
                Console.WriteLine("Sum of All nuber is " + sum);
            }
            Console.ReadKey();  
        }
    }
}
