using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//example of variable length parameter list

namespace Variable_length_parameter_list
{
    internal class Program
    {
        static int Display(params int[] num)
        {
            int i, result = 0;
            for(i =0; i < num.Length; i++)
            {
                result = result + num[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            int total = Display(1, 2, 3);
            Console.WriteLine("total is = " + total);
            Console.ReadKey();

        }
           
    }
}
