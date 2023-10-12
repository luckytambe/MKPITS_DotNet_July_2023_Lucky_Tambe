using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Enter Value");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Value is =  " + a);
            Console.ReadKey();
        }
    }
}
