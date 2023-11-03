using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2- create a class book and constructor with no parameters and another constructor with 4 parameters
namespace Parameterized_constructor_or_constructor_overloading
{
    class booK
    {
        public int srno ;
        public string course;
        public string name;
        public int fees;

        public booK()
        {
            srno = 1;
            course = "Java";
            name = "Lucky";
            fees = 75000;
        }

        public booK ( int srno , string course, string name ,int fees)
        {
            this.srno = srno;
            this.course = course;
            this.name = name;
            this.fees = fees;
           
        }
        
        public  void displaydata()
        {
            Console.WriteLine("Srno : "+ srno);
            Console.WriteLine("Course :"+ course);
            Console.WriteLine("Name : "+  name);    
            Console.WriteLine("Fees :"+ fees);
        }
    
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            booK boo = new booK();
            boo.displaydata();

            booK boo1 = new booK(22,"Python","rahul",50000);
            boo1.displaydata();

            Console.ReadKey();


        }
    }
}
