using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchOperatorsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2 ,addition , subtration , multiplication , division ,choice ;
            Console.WriteLine("1.Addition \n 2.subtration \n 3.multiplication \n 4.division ");

            Console.WriteLine("Enter Choice : ");
            choice=Convert.ToInt32(Console.ReadLine()); 

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter num1");
                    num1=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter num2");
                    num2=Convert.ToInt32(Console.ReadLine());

                    addition=num1 + num2;
                    Console.WriteLine("Addition is  = "+ addition);
                    break;

                case 2:
                    Console.WriteLine("Enter num1");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter num2");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    subtration = num1 + num2;
                    Console.WriteLine("subtration is = " + subtration);
                    break;

                case 3:
                    Console.WriteLine("Enter num1");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter num2");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    multiplication = num1 + num2;
                    Console.WriteLine("multiplication is  = " + multiplication);
                    break;

                case 4:
                    Console.WriteLine("Enter num1");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter num2");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    division = num1 / num2;
                    Console.WriteLine("division is  = " + division);
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            Console.ReadLine();
        }
    }
}
