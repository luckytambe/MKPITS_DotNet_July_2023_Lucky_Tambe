using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_member_Example
{
    class book
    {
        static string name ;
        static int age;

        static book()
        {
            Console.WriteLine("Static Constructor Call");
            name = "MKPITS";
            age = 45;
        }
       public static void display()
        {
            Console.WriteLine("Name : "+name);
            Console.WriteLine("Age  : " + age);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            book.display();
            Console.ReadKey();
        }
    }
}
