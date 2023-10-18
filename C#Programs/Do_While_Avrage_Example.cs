using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//4. Write a C# Sharp program to read 10 numbers and find their average and sum.
//Test Data :
namespace Do_While_Avrage_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, counter = 1;
            int  sum = 0;
            float avg = 0;

            do
            {
                Console.WriteLine("Enter num");
                num = Convert.ToInt32(Console.ReadLine());
              
                sum = sum + num;
                avg = sum / 10;

                counter++;
            }
            while (counter <= 10);
            Console.WriteLine("Sum is = " + sum);
            Console.WriteLine("avg is = " + avg);
            avg = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();


        }
    }
}
