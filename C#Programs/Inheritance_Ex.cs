using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Single_level_Inheritance

namespace Inheritance_Ex
{
    class employe //base Class 
    {
        public string name;
    }
    class person : employe //derived Class
    {
        public int salary;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            person per = new person();
            per.name = "Lucky";
            per.salary = 15200;

            Console.WriteLine(per.name);
            Console.WriteLine(per.salary);

            Console.ReadKey();
        }
    }
}
