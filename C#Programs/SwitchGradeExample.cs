using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchGradeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char grade;
            Console.WriteLine("Enter grade");
            grade=Convert.ToChar(Console.ReadLine());

            switch (grade)
            {
                case 'e':
                    Console.WriteLine("Excellent");
                    break;
                case 'v':
                    Console.WriteLine("Very Good");
                    break;
                case 'g':
                    Console.WriteLine("Good");
                    break;
                case 'a':
                    Console.WriteLine("Avarage");
                    break;
                case 'f':
                    Console.WriteLine("Fail");
                    break;

                default:
                    Console.WriteLine("Invalid grade");
                    break;


            }
            Console.ReadKey();

        }
    }
}
