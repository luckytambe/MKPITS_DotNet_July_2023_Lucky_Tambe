using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe_Constructor
{
    class employe
    {
        long Empno;
        string Name;
        string designation;
        int salary;

        public employe()
        {
            Empno = 8485889337;
            Name = "Lucky Tambe";
            designation = "CEO";
            salary = 100000;

        }

        public employe(int Empno, string Name, string designation, int salary)
        {
            this.Empno = Empno;
            this.Name = Name;
            this.designation = designation;
            this.salary = salary;
        }

        public void display()
        {
            Console.WriteLine("Empno :" + Empno);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("designation :" + designation);
            Console.WriteLine("Salary :" + salary);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Without Paramater------");

            employe emp = new employe(); //this will call constructor with no parameter automatically
            emp.display();

            Console.WriteLine("--------With Paramater------");


            employe emp1 = new employe(788739, "Swamini Tambe", "Manager", 85000);
            emp1.display();

            Console.WriteLine("--------From User------");
            // Form User 

            Console.WriteLine("Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name");
            string name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter designation");
            string desi=Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Salary");
            int sal= Convert.ToInt32(Console.ReadLine());

            employe emp2= new employe(num, name, desi,sal);
            emp2.display();


            


            Console.ReadKey();
        }
    }
}
