using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Collection_Class_Example
{
    class Student
    {
        public int roll;
        public string name;

        public Student(int roll, string name)
        {
            this.roll = roll;
            this.name = name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "Lucky");
            Student s2 = new Student(2, "Akash");
            Student s3 = new Student(3, "Devid");

            Queue SQ = new Queue();
            SQ.Enqueue(s1);
            SQ.Enqueue(s2);
            SQ.Enqueue(s3);

            foreach( Student val in SQ)
            {
                Console.WriteLine(" Rno : " +  val.roll);
                Console.WriteLine("Name : " + val.name);
            }

            Student r = (Student) SQ.Dequeue(); 
            Console.WriteLine("roll no : " +  r.roll + "name  : " + r.name);

            Console.WriteLine("After Duque");
            foreach( Student val in SQ)
            {
                Console.WriteLine(val.roll);
            }

            Console.ReadKey();

        }
    }
}
