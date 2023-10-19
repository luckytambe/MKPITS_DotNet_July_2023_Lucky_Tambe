using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//4. Write a C# Sharp program to read 10 numbers and find their average and sum.Test Data :

namespace For_Avarage_number_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            float avg = 0;
            int sum = 0;

            Console.WriteLine("Enter Numbers Five Times");
            number = Convert.ToInt32(Console.ReadLine());

            for (int counter = 1; counter <= number; counter++)
            {
                Console.WriteLine(counter);
                sum = sum + counter;
                avg = sum / number;

            }
            Console.WriteLine("Avg = " + sum);
            
            Console.WriteLine("Avg = " + avg);
            Console.ReadKey();
        }
    }
}
