using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inheritance_With_Emthod_Ex2
{
    class Student
    {
        public string name;
        public int age;
    }
    class Person : Student
    {
        int rno;
        public void getdata( string name , int age , int rno)
        {
            this.name = name;
            this.age = age;
            this.rno = rno;
        }

        public void Displaydata()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Rno : " + rno);
        }
    
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Person p= new Person();
            p.getdata("Rakesh", 25, 1);
            p.Displaydata();
            Console.ReadKey();
        }
    }
}
