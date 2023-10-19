using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Cube_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int cube = 0;


            Console.WriteLine("Enter Number");
            number=Convert.ToInt32(Console.ReadLine());
            for (int counter=1; counter<=number; counter++)
            {
                Console.WriteLine(counter);
                cube = number * number * number;

            }
            Console.WriteLine("The Cube is : " + cube);
            Console.ReadKey();              
            
        }
    }
}
