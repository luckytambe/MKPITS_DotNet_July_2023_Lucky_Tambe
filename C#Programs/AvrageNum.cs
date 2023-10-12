using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvarangeNumber
{
    internal class Program
    {
        public static void Main()
        {
            int number1, number2, number3, number4;
            float avg;

            Console.Write("Enter the First number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            number4 = Convert.ToInt32(Console.ReadLine());

            avg = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine("The average of: " + number1 + ", " + number2 + ", " + number3 + ", " + number4 + " is " + avg);
            Console.ReadKey();
        }
    }

    Sample Output:
}