using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name;
            Console.WriteLine("Enter name");
            name= Console.ReadLine();
            Console.WriteLine("hello " + name);
            Console.ReadLine();
        }
    }
}
