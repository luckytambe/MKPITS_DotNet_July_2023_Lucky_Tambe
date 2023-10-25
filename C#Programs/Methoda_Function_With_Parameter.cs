using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methoda_Function_With_Parameter
{
    internal class Program
    {
        static void Function(string name)
        {
            
            Console.WriteLine("Welcome friend {0}!\n Have a nice day!", name);
            
        }
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Enter name : ");
            name=Convert.ToString(Console.ReadLine());
            Function(name);
            Console.ReadKey();
        }
    }
}
