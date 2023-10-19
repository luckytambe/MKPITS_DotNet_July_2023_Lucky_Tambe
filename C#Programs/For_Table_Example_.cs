using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//Write a program in C# Sharp to display the multiplication table of a given integer.Test Data :
namespace For_Table_Example_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int Counter;
            int sum = 0;

            Console.WriteLine("Enter number");
            number=Convert.ToInt32(Console.ReadLine());

            for( Counter=1; Counter<=10; Counter++)
            { 
                sum= number*Counter;
                Console.WriteLine("{0} x {1} = {2}", number, Counter, sum);
            }

            Console.ReadKey();

        }
    }
}
