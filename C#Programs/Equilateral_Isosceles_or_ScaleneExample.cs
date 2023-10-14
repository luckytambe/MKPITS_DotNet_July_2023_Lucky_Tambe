using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Equilateral_Isosceles_or_ScaleneExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sideA, sideB, sideC;

            Console.WriteLine("Enter Side A");
            sideA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter side B");
            sideB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Side C");
            sideC = Convert.ToInt32(Console.ReadLine());

            if(sideA == sideB && sideB == sideC)
            {
                Console.Write("It is Equilateral Trangle Both side are same ");
            }
            else if (sideA == sideB && sideA == sideB && sideB == sideC)
            {
                Console.Write("it is Isosceles Trangle");
            }
            else
            {
                Console.Write("it is Scalen Trangle");
            }

            Console.ReadKey();
        }
    }
}
