using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekDaysExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Num");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (num == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (num == 3)
            {
                Console.WriteLine("Wednusday");
            }
            else if (num == 4)
            {
                Console.WriteLine("Thusday");
            }
            else if (num == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (num == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (num == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadLine();
        }
    }
}
