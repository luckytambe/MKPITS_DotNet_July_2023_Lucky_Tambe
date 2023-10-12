using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Example11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, sum;
            Console.WriteLine("enter X");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter X");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter X");
            z = Convert.ToInt32(Console.ReadLine());

            sum = (x + y) * z;

            Console.WriteLine("Sum = " + sum);
           

            sum = x * y + y * z;
            Console.WriteLine("Sum = " + sum);
            Console.ReadKey();
        }
    }
}
