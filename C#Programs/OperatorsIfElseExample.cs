using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsIfElseExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, Choice, total;

            Console.WriteLine("Enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENter num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.Addition\n2.Substract\n3.Multiply\n4.Divide\n5.Exit");
            Choice = Convert.ToInt32(Console.ReadLine());


            if (Choice == 1)
            {
                total = num1 + num2;
                Console.WriteLine(" Addition = " + total);
            }
            else if(Choice == 2)
            {
                total = num1 - num2;
                Console.WriteLine(" Subtration = " + total);
            }
            else if (Choice == 3)
            {
                total = num1* num2;
                Console.WriteLine(" Subtration = " + total);
            }
            else if (Choice == 4)
            {
                total = num1 / num2;
                Console.WriteLine(" Subtration = " + total);
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }




            Console.ReadKey();




        }
    }
}
