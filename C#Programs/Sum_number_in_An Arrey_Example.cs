using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_number_in_An_Arrey_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Number : ");
                num[i]= Convert.ToInt32(Console.ReadLine());
            }
            for(int i =0;i<3;i++)
            {
                sum = sum + num[i];
                
            }
            Console.WriteLine("Sum_number_is {0}", sum);
            Console.ReadKey();
        }
    }
}
