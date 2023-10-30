using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrey_Index_Of_Length_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5 };
            int l = Array.IndexOf(num,5);
            Console.WriteLine(l);
            Console.ReadKey();

        }
    }
}
