using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifire_Internal_Ex
{
    class Employe
    {
        internal string name;
        internal int salary;

        public void display()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Salary : " + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe e = new Employe();
            e.name = "sarang";
            e.salary = 5000;

            e.display();    

            Console.ReadKey();  
        }
    }
}
