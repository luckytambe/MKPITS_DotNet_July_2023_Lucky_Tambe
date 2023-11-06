using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_With_Different_Object
{
    class Book
    {
        static string name;
        static int age;

        static Book()
        {
            name = "Akash";
            age = 22;
        }

        public void Display()
        {
            Console.WriteLine("NAME = " + name);
            Console.WriteLine("Age = " + age);
        } 
       
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book boo=new Book();
            boo.Display();
            Console.ReadKey();
        }
    }
}
