using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Single_Inheritance
{
    class Person
    {
        public string Name;
        public string Address;
    }

    class Employe : Person
    {
        public int Empno;
        public int salary;
        public string designation;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employe emp = new Employe();

            emp.Name = "Lucky";
            emp.Address = "Nagpur";
            emp.Empno = 1;
            emp.salary = 5000;
            emp.designation = "Manager";

            Console.WriteLine("Name : " + emp.Name);
            Console.WriteLine("Address :"+ emp.Address);
            Console.WriteLine("Empno : " + emp.Empno);
            Console.WriteLine("Salary : " + emp.salary);
            Console.WriteLine("Desigation : " + emp.designation);

            Console.ReadKey();
        }
    }
}
