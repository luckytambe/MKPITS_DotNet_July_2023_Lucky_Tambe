using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Example2
{
    class Employe
    {
        static string name;
        static int salary;
        static Employe()
        {
            name = "Devid ";
            salary = 50000;
        }
       public static void display()
        {
            Console.WriteLine(name);
            Console.WriteLine(salary);
        }  
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe.display();
            Console.ReadKey();
        }
    }
}
