using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostIncrement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = i++;
            Console.WriteLine("Value of i is = " + i  + "\ value of j is = " + j);
            Console.ReadKey();
        }
    }
}
