using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortUShortExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short a;
            Console.WriteLine("Enter Value");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(" Short = " + a);
            Console.ReadKey();

            ushort b;
            Console.WriteLine("ENter num");
            b = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Short = "+ b);
            Console.ReadKey();
                
                
        }
    }
}
