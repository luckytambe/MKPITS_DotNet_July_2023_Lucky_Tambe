using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiusProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;

            float area, Circumference;
            Console.WriteLine("Enter Radius");
            radius = Convert.ToInt32(Console.ReadLine());
            area = 3.14f*radius * radius;
           
            Circumference = 2 * 3.14f * radius;
            Console.WriteLine("Area = " + area);
            Console.WriteLine("circumference = " + Circumference);
            Console.ReadKey();
        }
    }
}
