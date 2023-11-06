using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Method_2_To_4_Parameter_Example
{
    class Student
    {
        int rno;
        string name;
        string course;
        int fees;

        public void getdata()
        {
            rno = 1;
            name = "Lucky";
            course = "DotNet";
            fees = 75000;
        }
        public void getdata( int rno , string name)
        {
            this.rno = rno;
            this.name = name;
        }
        public void getdata( int rno , string name , string course)
        {
            this.rno= rno;
            this.name = name;
            this.course = course;
        }
        public void getdata( int rno, string name , string course, int fees)
        {
            this.rno=rno;
            this.name = name;
            this.course = course;
            this.fees = fees;
        }

        public void displaydeta()
        {
            Console.WriteLine("Roll no : " + rno );
            Console.WriteLine("Name    : "+ name);
            Console.WriteLine("Course  : " + course);
            Console.WriteLine("Fees    : " + fees);
        }    
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Method_Paramater_To_Single_");
            Student stud = new Student();
            stud.getdata();
            stud.displaydeta();

            Console.WriteLine("-----Method_Paramater_To_Double_");
            Student stud2= new Student();
            stud2.getdata(2,"Devid");
            stud2.displaydeta();

            Console.WriteLine("-----Method_Paramater_To_Three_");
            Student stud3 = new Student();
            stud3.getdata( 3, "Devid","Java");
            stud3.displaydeta();

            Console.WriteLine("-----Method_Paramater_To_Four_");
            Student stud4 = new Student();
            stud4.getdata(4, "Devid", "Java",50000);
            stud4.displaydeta();

            Console.ReadKey();
        }
    }
}
