using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While1to10Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1 ;
            

            while (num <= 10)
            {
                Console.WriteLine(" num is = " + num);
                num++;
            }

            Console.ReadKey();
        }
    }
}
