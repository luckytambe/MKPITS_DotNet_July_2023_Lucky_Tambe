using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Single_Inheritance_With_Method
{
    class person
    {
        public string name;
        public string address;
    }

    class employe : person
    {
        int empno;
        int salary;
        string designation;

        public void getdata(string name , string address , int empno , int salary , string designation)
        {
            this.name = name;
            this.address = address;
            this.empno = empno;
            this.salary = salary;
            this.designation = designation;
        }

        public void displaydata()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Address : " + address);
            Console.WriteLine("empnp : "+  empno);
            Console.WriteLine("Salary : " + salary);
            Console.WriteLine("Designation : " + designation);
        }
    
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            employe emp= new employe();

            emp.getdata("Devid", "Nagpur", 1, 5000, "Manager");
            emp.displaydata();
            Console.ReadKey();
        }
    }
}
