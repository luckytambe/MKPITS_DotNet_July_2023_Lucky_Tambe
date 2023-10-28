using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Of_Arrey_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];

            int sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Enter Number");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0;i < num.Length; i++)
            {
                
                sum = sum + num[i];
                
            }
            Console.WriteLine("Sum is = " + sum);
            Console.ReadKey();
        }
    }
}
