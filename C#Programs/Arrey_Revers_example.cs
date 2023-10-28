using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrey_Revers_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int [5];

            for(int i = 0;i<5;i++)
            {
                Console.WriteLine("Enter number :");
                num[i]=Convert.ToInt32(Console.ReadLine()); 
            }
            Console.WriteLine("Reverse:");
            for ( int i=4; i>=0;i--)
            {
                Console.Write("{0} ", num[i]);
            }
            Console.ReadKey();
        }
    }
}
