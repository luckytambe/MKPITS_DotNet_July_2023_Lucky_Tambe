using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthBreath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length, breath, area;
            Console.WriteLine("Enter Length");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Breath");
            breath = Convert.ToInt32(Console.ReadLine());

            area = length * breath;
            Console.WriteLine("Area = " + area);
            Console.ReadKey();


        }
    }
}
