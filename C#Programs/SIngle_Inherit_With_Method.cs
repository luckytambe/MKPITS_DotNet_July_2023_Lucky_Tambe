using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIngle_Inherit_With_Method
{
    class Employe
    {
        public string name;
    }

    class Person : Employe
    {
        int salary;

        public void getdata( string name, int salary )
        {
            this.name = name;
            this.salary = salary;
        }

        public void displaydata()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Salary :" + salary);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person();

            per.getdata("Lucky", 5000);
            per.displaydata();

            Console.ReadKey();

        }
    }
}
