using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_with_no_parameters_Employe
{
    internal class Program
    {
        class Employe
        {
            public int empno;
            public string name;
            public string desination;
            public int salary;

              public Employe ()
            {
                empno =1 ;
                name = "Rakesh";
                desination = "Manager";
                salary = 10000;

            }
              public void displaydata()
            {
                Console.WriteLine("EmpNo : "+ empno);
                Console.WriteLine("Name : " + name);
                Console.WriteLine("Desination : "+  desination);
                Console.WriteLine("Salary : " + salary);

            }        
        
        
        }

        static void Main(string[] args)
        {
            Employe emp = new Employe();
            emp.displaydata();
            Console.ReadKey();
        }
    }
}
