using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_table_Example_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sn = 1, vn = 2;
            int res, res1;

            int counter = 1;
            do
            {
                res=sn*counter;
                res1=vn*counter;
                Console.WriteLine("{0}*{1}={2}", sn, counter, res);
                Console.Write("\t");
                Console.WriteLine("{0}*{1}={2}", vn, counter, res1);
                counter++;
            }
            while (counter <= 10);

            Console.ReadKey();

        }
    }
}
