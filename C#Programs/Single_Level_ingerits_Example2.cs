using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Level_ingerits_Example2
{
    class Employe
    {
        public string name = "Rakesh";
    }
    class person : Employe
    {
        public int salary = 100000;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            person per= new person();

            Console.WriteLine("Name : "+  per.name);
            Console.WriteLine("Salary :" + per.salary);
            Console.ReadKey();  
        }
    }
}
