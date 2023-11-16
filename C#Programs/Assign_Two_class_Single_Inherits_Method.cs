using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Two_class_Single_Inherits_Method
{
    class person
    {
        public string name;
        public string address;

        public void getpersondata (string name , string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displaypersondata()
        {
            Console.WriteLine("Name : "+ name);
            Console.WriteLine("Address : "+  address);
        }
    }

    class employe : person
    {
        public int empno;
        public int salary;

        public void getemployedata(int empno, int salary)
        {
            this.empno = empno;
            this.salary = salary;
        }
        public void displayemployedata()
        {
            Console.WriteLine("Empno : " +empno);
            Console.WriteLine("Salary : "+  salary);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            employe emp = new employe();

            emp.getpersondata("Lucky", "Nagpur");
            emp.getemployedata(1, 5000);

            emp.displaypersondata();
            emp.displayemployedata();

            Console.ReadKey();
        }
    }
}
