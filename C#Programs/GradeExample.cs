using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String grade;

            Console.WriteLine("enter grade");
            grade = Console.ReadLine(); 

            if (grade == "e")
            {
                Console.WriteLine("Excilent"); 
            }
            else if (grade == "v")
            {
                Console.WriteLine("VeryGood");
            }
            else if (grade == "g")
            {
                Console.WriteLine("good");
            }

            else if (grade == "a")
            {
                Console.WriteLine("Avrage");
            }
            else if (grade == "f")
            {
                Console.WriteLine("fail");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            Console.WriteLine(+ grade);
            Console.ReadKey();

        }
    }
}
