using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inheritance_Protected_internal_Example
{

    class person
    {
        public int id;
        public string name;

        protected internal void getperdata(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        protected internal void displayperdata()
        {
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Name : " + name);
        }
    }

    class employe : person
    {
         int empno;
        int salary;

        public void getempdata(int empno, int salary)
        {
            this.empno = empno;
            this.salary = salary;
        }

        public void displayempdata()
        {
            Console.WriteLine("Empno : " + empno);
            Console.WriteLine("Salary : " + salary);
        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            employe emp = new employe();

            emp.getperdata(1, "lucky");
            emp.getempdata(8888, 5000);
            emp.displayperdata();
            emp.displayempdata();

            Console.ReadKey();
        }
    }
}
