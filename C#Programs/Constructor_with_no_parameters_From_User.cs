using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_with_no_parameters_From_User
{
    class Student

    {
        public int srno;
        public string name;
        public int Standard;
        public int fees;

        public  Student ( int srno , string name , int Standard , int fees )
        {
            this.srno = srno;
            this.name=name;
            this.Standard =Standard;
            this.fees =fees;
        }

        public void displaydata()
        {
            Console.WriteLine("Srno : " + srno);
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Standard : " + Standard);
            Console.WriteLine("Fees :" + fees);
        }
      
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter Srno");
            int s1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name");
            string n1= Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter standard");
            int s2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Fees");
            int f1 = Convert.ToInt32(Console.ReadLine());


            Student stud = new Student(s1,n1,s2,f1);  

            stud.displaydata();
            Console.ReadKey();
        }
    }
}
