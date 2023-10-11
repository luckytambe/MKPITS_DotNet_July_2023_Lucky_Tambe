using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProgramm
{
    internal class Program
    {
        public static void Main()
        {
            int num, cube;

            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            cube = num * num*num;
            Console.WriteLine("Square = " + cube);
            Console.ReadKey();
        }
    }
}

