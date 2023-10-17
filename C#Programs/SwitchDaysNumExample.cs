using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDaysNumExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Month Number");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("31 days");
                    break;
                case 2:
                    Console.WriteLine("28 , 30 days");
                    break;
                case 3:
                    Console.WriteLine("30 days");
                    break;
                case 4:
                    Console.WriteLine("31 days");
                    break;
                case 5:
                    Console.WriteLine("30 days");
                    break;
                case 6:
                    Console.WriteLine("30 days");
                    break;
                case 7:
                    Console.WriteLine("31 days");
                    break;
                case 8:
                    Console.WriteLine("31 days");
                    break;
                case 9:
                    Console.WriteLine("30 days");
                    break;
                case 10:
                    Console.WriteLine("30 days");
                    break;
                case 11:
                    Console.WriteLine("31 days");
                    break;
                case 12:
                    Console.WriteLine("31 days");
                    break;

                default:

                    Console.WriteLine("Invalid day");
                    break;
            }

            Console.ReadKey();

        }   

    }
}
