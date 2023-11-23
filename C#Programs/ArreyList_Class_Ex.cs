using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace ArreyList_Class_Ex
{
    class Student
    {
        public int id;
        public string name;

        public Student( int id , string name )
        {
            this.id = id;
            this.name = name;
        }      

    } 

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, "sujit");
            Student s2 = new Student(2, "Trishla");
            Student s3 = new Student(3, "khangar");

            ArrayList ar = new ArrayList();
            ar.Add(s);
            ar.Add(s2);
            ar.Add(s3);

            foreach(Student ob in ar )
            {
                Console.WriteLine("id " + ob.id  );
                Console.WriteLine("Name " + ob.name);
            }
            Console.ReadKey();
        }

    }
}
