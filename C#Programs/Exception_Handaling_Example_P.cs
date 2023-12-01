using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handaling_Example_P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n;

            Console.WriteLine("Enter num ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter n ");
            n = Convert.ToInt32(Console.ReadLine());

            int res = 0;

            try
            {
                res = num / n;
            }
            catch(Exception)
            {
                Console.WriteLine(" cannot divide by zero ");
            }
            Console.WriteLine("res = " + res);
            Console.WriteLine("bye");
            Console.ReadKey();
        }
    }
}
