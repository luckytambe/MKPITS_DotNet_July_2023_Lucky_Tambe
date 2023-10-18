using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1- wap to print 1 to 5 using do while loop

namespace Do_While_1_To_5_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=1;

            do 
            {
                Console.WriteLine("num {0}", num);
                num++;
            }
            
            while (num <= 5)
                      

            Console.ReadKey();
        }
    }
}
