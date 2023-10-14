using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Trangle_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a , b , c ;

            Console.WriteLine("Enter Three parameter");

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

           if(a==b && b==c)
            {
                Console.WriteLine("It is trangle");
            }
           else
            {
                Console.WriteLine("It is not trangle");
            }

            Console.ReadKey();
        }
    }
}
