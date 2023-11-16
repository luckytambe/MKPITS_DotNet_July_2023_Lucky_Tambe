using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class person
    {
        public string name;

        protected void getperdata(string name)
        {
            this.name = name;
        }

        protected void displayperdata()
        {
            
            Console.WriteLine("Name : " + name);
            
         
        }

    }
    class employe : person
    {
        public int salary;
        public int empno;

        public void getempdata(int salary , int empno)
        {
            getperdata("Lucky");
            displayperdata();
            this.salary = salary;
            this.empno = empno;
        }

        public void displayempdata()
        {
            Console.WriteLine("Salary : " + salary);
            Console.WriteLine("Empno : " + empno);
        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            employe emp=new employe();

            emp.getempdata(5000, 1);
            emp.displayempdata();

            Console.ReadKey();
        }
    }
}
