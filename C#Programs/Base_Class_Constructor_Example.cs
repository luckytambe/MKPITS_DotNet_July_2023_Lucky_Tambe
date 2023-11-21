using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Class_Constructor_Example
{
    class Employe
    {
        public string name = "TCS";

        public Employe()
        {
            Console.WriteLine("Base Class COnstructor");
            Console.WriteLine("Company name : " + name);
        }
    }
    class Company : Employe
    {
        public string name = "Lucky";
        public Company()
        {
            Console.WriteLine("Base Class Constructor");
            Console.WriteLine("Employe Name : " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Company c = new Company();
            Console.ReadKey();
        }
    }
}
