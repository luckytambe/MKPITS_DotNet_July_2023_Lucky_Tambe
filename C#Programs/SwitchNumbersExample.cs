using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchNumbersExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("ENter number");
            num=Convert.ToInt32(Console.ReadLine());

            switch(num)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;

                default:
                    Console.WriteLine("Only gives One to Ten number");
                    break;

            }

            Console.ReadKey();

        }
    }
}
