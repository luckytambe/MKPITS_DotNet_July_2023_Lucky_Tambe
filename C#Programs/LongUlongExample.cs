using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongUlongExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine("Enter Value");
            a = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Value is =  " + a);
            Console.ReadKey();

            long b;
            Console.WriteLine("Enter Value");
            b = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Value is =  " + b);
            Console.ReadKey();
        }
    }
}
