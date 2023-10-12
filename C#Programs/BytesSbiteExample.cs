using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytesSbiteExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b;
            Console.WriteLine("Enter Byte");
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Bytes " + b);
            Console.ReadKey();

            sbyte b1;
            Console.WriteLine("Enter Sbyte");
            b1 = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("sbyte" + b1);
            Console.ReadKey();
        }
    }
}

