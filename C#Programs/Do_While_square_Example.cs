using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//wap to accept a number and print square and then ask the user "whether you want ot continue or not " , if user press y
//then ask for another number other wise exit the program using do while loop
namespace Do_While_square_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, square;
            char choose = 'y';

            do
            {
                Console.WriteLine("Enter num");
                num = Convert.ToInt32(Console.ReadLine());
                square = num * num;
                Console.WriteLine("Square is = "+ square);
                Console.WriteLine("Do you Want To Contineu press Y ");
                choose = Convert.ToChar(Console.ReadLine());

            }
            while (choose == 'y');
            Console.ReadKey();
        }
    }
}
