using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Collection_Class_E
{
    class Student
    {
        public int Id;
        public string Name;
        public Student(int id , string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, "Lucky");
            Student s1 = new Student(2, "Rakesh");
            Student s3 = new Student(3, "Mohit");

            Queue r = new Queue();
            r.Enqueue(s);
            r.Enqueue(s1);
            r.Enqueue(s3);

            foreach(Student stud in r)
            {
                Console.WriteLine("Roll : " + stud.Id);
                Console.WriteLine("Name : " + stud.Name);
            }



            Console.ReadKey();
        }
    }
}
