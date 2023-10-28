using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_1To_10Arrey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number : ");
                number[i]=Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Element by {0} value is {1}",i,number[i]);
            }
            Console.WriteLine("Element by Arrey are :");
            for(int i = 0;i < 10; i++)
            {
                Console.WriteLine("{0}", number[i]);
            }
            Console.ReadKey();
        }
    }
}
