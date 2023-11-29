using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catch_and_finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int num;

            Console.WriteLine("Enter Number");
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
                Console.WriteLine("It is not divide Zero");
            }

            finally
            {
                Console.WriteLine("the Block Excicute");
                Console.WriteLine("Res : " + res);
            }
            Console.WriteLine("Bye");

            Console.ReadKey (); 
            
        }
    }
}
