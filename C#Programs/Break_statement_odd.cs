using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_statement_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            for (num = 1; num <= 10; num++)
            {

                Console.WriteLine(num);
                if (num == 8)
                {
                    break;
                }
             
            }
            Console.ReadKey();
        }
    }
}
