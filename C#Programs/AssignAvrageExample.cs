using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignAvrageExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            float avg = 0;
            float sum = 0;
            
            while (num <= 10)
            {
                Console.WriteLine("num is " + num);
                avg = sum / 10;
                sum = num + sum;
                num++;
            }
            Console.WriteLine("sum is = " + sum);
            Console.WriteLine("avg is = " + avg);

            Console.ReadKey();
        }
    }
}
