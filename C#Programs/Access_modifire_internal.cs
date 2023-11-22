using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifire_internal
{
    class student
    {
        internal int id;
        internal string name;
        internal int age;

        public void display()
        {
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " +  age);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student stud = new student();
           stud.id = 1;
        stud.name = "Sujit";
            stud.age = 24;

            stud.display();

            Console.ReadKey();
            
        }
    }
}
