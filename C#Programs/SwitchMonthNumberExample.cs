using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchMonthNumberExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Month Number");
            num=Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Jan");
                    break;
                case 2:
                    Console.WriteLine("Feb");
                    break;
                case 3:
                    Console.WriteLine("Mar");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("Jully");
                    break;
                case 8:
                    Console.WriteLine("Aug");
                    break;
                case 9:
                    Console.WriteLine("sep");
                    break;
                case 10:
                    Console.WriteLine("Oct");
                    break;
                case 11:
                    Console.WriteLine("Nov");
                    break;
                case 12:
                    Console.WriteLine("Dec");
                    break;

                default:
                    Console.WriteLine("Invalid day");
                    break;
            }

            Console.ReadKey();
        }
    }
}
