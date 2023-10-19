using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//Write a C# Sharp program to display the n terms of odd natural numbers and their sums. Test Data Input number of terms : 10 Expected Output :

namespace ODD_Natural_Number_Sum_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int counter;
            int sum = 0;

            Console.WriteLine("Enter Number");
            number=Convert.ToInt32(Console.ReadLine());

            for( counter=1; counter<=number; counter++)
            {
                if (counter % 2 == 1)
                {
                    Console.WriteLine(counter);
                    sum = sum + counter;
                   
                }
            }
            Console.WriteLine("Sum is = " + sum);
            Console.ReadKey();
        }
    }
}
