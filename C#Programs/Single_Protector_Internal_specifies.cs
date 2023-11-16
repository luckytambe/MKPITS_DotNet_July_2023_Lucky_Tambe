using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Protector_Internal_specifies
{
    class employe
    {
        public int id;
        public string name;

        protected void getemployedata(int id,string name)
        {
            this.id= id;
            this.name= name;
        }

        protected void displayemployedata()
        {
            Console.WriteLine("id : " + id);
            Console.WriteLine("Name : "+ name);
        }
    }

    class person : employe
    {
        public int empno;
        public int salary;

        public void getpersondata( int empno , int salary ) 
        {
          getemployedata(1, "Lucky");
          displayemployedata();
          this.empno= empno;
          this.salary= salary;
        }

        public void displayperdata()
        {
            Console.WriteLine("Empno : " + empno);
            Console.WriteLine("Salary : " + salary);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            person p = new person();

            p.getpersondata(1, 5000);
            p.displayperdata();

            Console.ReadKey();
        }
    }
}
