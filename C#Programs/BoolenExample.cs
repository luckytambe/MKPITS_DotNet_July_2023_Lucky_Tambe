using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolenExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean a = true;
            Boolean b = false;
            Console.WriteLine("Enter Value");
            a = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter Value");
            b = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Value is =  " + a);

            Console.WriteLine("Value is =  " + b);
            Console.ReadKey();
        }
    }
    
}
