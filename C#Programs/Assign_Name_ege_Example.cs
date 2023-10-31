using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assign_Name_ege_Example
{
    internal class Program
    {
        class person
        {
            string Name;
            int age;
            string address;

            public void getdata(string Name, int age, string address)
            {
                this.Name = Name;
                this.age = age;
                this.address = address;
            }
            public void displaydata()
            {
                Console.WriteLine("Name is = " + Name);
                Console.WriteLine("Age is = " + age);
                Console.WriteLine("Address = " + address);

            }
        }
        static void Main(string[] args)
        {
            person per= new  person();
            per.getdata("lucky =", 24, " Buddha nagar");
            per.displaydata();
            Console.ReadKey();
            
        }
    }
}
