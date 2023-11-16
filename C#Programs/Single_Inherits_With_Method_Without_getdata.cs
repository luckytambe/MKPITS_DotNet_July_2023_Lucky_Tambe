using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inherits_With_Method_Without_getdata
{
    class Student
    {
        public int id;
        public string name;
    }
    class Person : Student
    {
        public string subject;
        public int marks;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Person p= new Person();

            p.id = 1;
            p.name = "Jockey";
            p.subject = "Chemistry";
            p.marks = 80;

            Console.WriteLine("ID : "+ p.id);
            Console.WriteLine("Name : "+ p.name);
            Console.WriteLine("Subject : "+ p.subject);
            Console.WriteLine("Marks : " + p.marks);

            Console.ReadKey();  
        }
    }
}
