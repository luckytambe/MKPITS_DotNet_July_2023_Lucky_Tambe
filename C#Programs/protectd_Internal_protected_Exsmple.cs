using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protectd_Internal_protected_Exsmple
{
    class person
    {
      public int id;
      
     protected void getpersondata(int id)
        {
            this.id = id;
        }
       
     protected void displaypersondata()
        {
           
            Console.WriteLine("id : " + id);
        }
    }

    class employe : person
    { 
       public string name;
       public int salary;

        protected internal void getemployedata(string name , int salary) 
        {
            getpersondata(1);
            this.name = name;
            this.salary = salary;
        }

        protected internal void displayempdata() 
        {
            displaypersondata();
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Salary : "+ salary);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            employe emp = new employe();

            emp.getemployedata("Lucky", 5000);
            emp.displayempdata();   

            Console.ReadKey();
        }
    }
}
