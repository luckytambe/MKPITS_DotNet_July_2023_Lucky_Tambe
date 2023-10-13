using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVenOrOddExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("ENter num");
            num = Convert.ToInt32(Console.ReadLine());

            if (num%2==0)
            {
                Console.WriteLine("It is Even num");
            }
            else
            {
                Console.WriteLine("It is odd ");
            }

            Console.ReadKey();
        }
    }
}
