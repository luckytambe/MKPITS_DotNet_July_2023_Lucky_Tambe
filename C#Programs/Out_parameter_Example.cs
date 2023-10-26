using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_parameter_Example
{//example of out parameter
    internal class Program
    {
        static void Display( int radius , out float area , out float circumference)
        {
            area = 3.14f * radius * radius;
            circumference = 2 * 3.14f * radius;
        }
        static void Main(string[] args)
        {
            int radius;
            float area , circumference ;
            Console.WriteLine("Enter radius : ");
            radius= Convert.ToInt32(Console.ReadLine());

            Display(radius, out area, out circumference);

            Console.WriteLine("Area is = " + area);
            Console.WriteLine("Circumference is = " + circumference);

            Console.ReadKey()
        }
    }
}
