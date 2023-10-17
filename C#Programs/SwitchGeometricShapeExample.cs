using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num , choice, area, square;
            float radius,circle;
            int l, b; 
            Console.WriteLine("1.area\n 2.square \n 3.circle");
            choice=Convert.ToInt32(Console.ReadLine());
           
            switch (choice)
            {
                case 1:

                    Console.WriteLine("Enter Length");
                    l=Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter breath");
                    b=Convert.ToInt32(Console.ReadLine()); 

                    area = l * b;
                    Console.WriteLine("Area is = : " + area);
                    break;

                case 2:

                    Console.WriteLine("Enter num");
                    num = Convert.ToInt32(Console.ReadLine());
                    square = num * num;
                    Console.WriteLine("Square is = " + square);
                    break;

                case 3:

                    Console.WriteLine("Enter radius");
                    radius=Convert.ToInt32(Console.ReadLine());
                    circle = 3.14f * radius * radius;
                    Console.WriteLine("Circle is = " + circle);
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;

            }

            Console.ReadKey();

        }
    }
}
