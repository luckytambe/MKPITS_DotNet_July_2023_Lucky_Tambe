using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Example
{
    class student
    {
        static string name;
        static int age;

        static student()
        {
            Console.WriteLine("Static mathod Called");
            name = "Akash";
            age = 22;
        }

        public static void display()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : "+ age);
        }
    
    
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            student.display();
            Console.ReadKey();
           
        }
    }
}
