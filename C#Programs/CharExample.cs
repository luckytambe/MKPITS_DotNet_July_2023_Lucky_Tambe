using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = 'C';
            Console.WriteLine("Enter Cherecter");
            a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("This is = " + a);
            Console.ReadLine();
        }
    }
}
