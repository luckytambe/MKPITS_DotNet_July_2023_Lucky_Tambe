using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MultiLevel_inheritance_Example.person;

namespace MultiLevel_inheritance_Example
{
   public class person
    {
        int id;
        string name;

         public void getperdata(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void displayperdata()
        {
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Name : "+ name);
        }

        public class employe : person
        {
            int salary;
            string  designation;

         public void getempdata(int salary, string designation) 
            {
                this.salary = salary;
                this.designation = designation;
            }

         public void displayempdata()
            {
                Console.WriteLine("Salary : " + salary);
                Console.WriteLine("designation : " + designation);
            }

        }

        public class working : employe
        {
            int hour;

            public void gethourdata(int hour)
            {
                this.hour = hour;
            }

            public void displayhourdeta()
            {
                Console.WriteLine("Hour : " + hour);
            }
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            working w = new working();

            w.getperdata(1,"Lucky");
            w.getempdata(5000, "Manager");
            w.gethourdata(8);
            w.displayperdata();
            w.displayempdata();
            w.displayhourdeta();

            Console.ReadKey();
        }
    }
}
