using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayNumberExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayno;
            Console.WriteLine("Enter Number");
            dayno = Convert.ToInt32(Console.ReadLine());

            switch (dayno)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednusday");
                    break;
                case 4:
                    Console.WriteLine("Thusday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("Invalid Days");
                    break;

            }
            Console.ReadKey();
        }
    }
}
