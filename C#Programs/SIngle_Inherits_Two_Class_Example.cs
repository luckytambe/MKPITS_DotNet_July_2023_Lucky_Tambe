using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIngle_Inherits_Two_Class_Example
{
    class employe
    {
        public int id;
        public string name;

        public void getemployedata(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void displayempdata()
        {
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Name : "+ name);
        }
    }

    class person : employe 
    {
        public string desi;
        public int salary;

        public void getpersodata(string desi, int salary)
        {
            this.desi = desi;
            this.salary = salary;
        }
        public void displayperdata()
        {
            Console.WriteLine("Designation : " + desi);
            Console.WriteLine("Salary : " + salary);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            person p= new person();

            p.getemployedata(1, "Devid");
            p.displayempdata();
            p.getpersodata("Maneger", 5000);
            p.displayperdata();

            Console.ReadKey();

        }
    }
}
