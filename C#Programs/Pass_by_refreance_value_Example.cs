using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass_by_refreance_value_Example
{
    internal class Program
    {
        static int num = 10;
        static void display(ref int num)
        {
            num = 20;
            Console.WriteLine(" input value by ref = " + num);
        }
        static void Main(string[] args)
        {
            int num = 10;
            display(ref num);
            Console.WriteLine("Inside value Output = " + num);
            Console.ReadKey();
        }
    }
}
