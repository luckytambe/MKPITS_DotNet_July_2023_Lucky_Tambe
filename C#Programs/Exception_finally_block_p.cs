using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_finally_block_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n;
            int res = 0;
            Console.WriteLine("Enter number ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter n ");
            n = Convert.ToInt32(Console.ReadLine());

            try
            {
                res = num * n;
            }
            catch(Exception)
            {
                Console.WriteLine("Not dividing by zero");
            }
            finally
            {
                Console.WriteLine("Solution will founded");
                Console.WriteLine("res = " + res);
            }
            Console.ReadKey();  
        }
    }
}
