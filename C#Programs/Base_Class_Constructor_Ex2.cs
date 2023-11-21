using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Class_Constructor_Ex2
{
    class Employe
    {
        public string name = "Lucky";

        public Employe()
        {
            Console.WriteLine("Calling Constructor");
            Console.WriteLine("Employe Name : " + name );
        }
    }

    class Company : Employe
    {
        public string name = "Tcs";
        public Company()
        {
            Console.WriteLine("Calling COnstructor");
            Console.WriteLine("Company Name : " + name);
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
