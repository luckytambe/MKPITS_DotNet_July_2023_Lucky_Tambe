using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("Enter num");
            temp = Convert.ToInt32(Console.ReadLine());

            if(temp < 0)
            {
                Console.WriteLine("Freazing weather");
            }
            else if(temp  >= 10 && temp <= 39)
            {
                Console.WriteLine("it is hot");
            }
            else
            {
                Console.WriteLine("It is very hot");
            }
            Console.ReadKey();
        }
    }
}
