using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Collection_class_Example2
{
    class Student
    {
        public int id;
        public string name;

        public Student( int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student(1,"Rakesh");
            Student S1 = new Student(2,"Rohit");
            Student S2 = new Student(3, "Mahesh");
            Queue s = new Queue();
            s.Enqueue(S);
            s.Enqueue(S1);
            s.Enqueue(S2);
            foreach (Student Std in s)
            {
                Console.WriteLine("Id : " + Std.id);
                Console.WriteLine("Name : " + Std.name);
            }
            Student r = (Student)s.Dequeue();
            Console.WriteLine( " Id : " + r.id  + "Name :" + r.name);
            Console.WriteLine("After Queue");
            foreach (Student Std in s)
            {
                Console.WriteLine(Std.id);
                Console.WriteLine(Std.name);
            }
            Console.ReadKey();

        }
    }
}
