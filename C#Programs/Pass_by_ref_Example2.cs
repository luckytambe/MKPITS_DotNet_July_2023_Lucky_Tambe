using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass_by_ref_Example2
{
    internal class Program
    {
        static void Calculate( int  radius, ref float area, ref float circumference)
        {
            area = 3.14f * radius * radius;
            circumference = 2 * 3.14f * radius;
        }
        static void Main(string[] args)
        {
            int radius = 5;
            float area = 0 , circumference = 0 ;
            Calculate(radius, ref area, ref circumference);
            Console.WriteLine("Area is = " + area);
            Console.WriteLine("Circumference is = " + circumference);
            Console.ReadKey();

        }
    }
}
