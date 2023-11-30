using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handaling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n;

            Console.WriteLine("Enter number ");
             num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());

            int res = 0;

            try
            {
                res = num / n;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Cannot divide by Zero");
            }

            Console.WriteLine(" res : " + res);
            Console.WriteLine("Bye");

            Console.ReadKey();
                
        }
    }
}
