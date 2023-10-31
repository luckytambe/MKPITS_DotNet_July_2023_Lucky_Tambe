using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Student_Avarage
{
    internal class Program
    {
        class Student
        {
            string name;
            int roll, sub;
            float avg = 0;
            int total = 0;

            public void getdata(string name , int roll, int total, float avg )
            {
                this.name = name;
                this.roll = roll;
                this.total=total;
                this.avg = avg;
            }

                public void displaydata()
            { 

                Console.WriteLine("Enter name :" + name);
                Console.WriteLine("Enter RollNo :" + roll);
                Console.WriteLine("Total Marks :" + total);
                Console.WriteLine("Avrage is  :"+ avg);

            }
        }

        static void Main(string[] args)
        {
            Student stud = new Student();
            int[] subject = new int[5];
            int total = 0;
            float avg = 0;
          
            string name= Convert.ToString(Console.ReadLine());
            int roll=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks : ");
            
          
           for(int i=0; i<5; i++)
            {
                subject[i]=Convert.ToInt32(Console.ReadLine());
            }
            for (int i=0; i<5;i++ )
            {
                 total = total + subject[i];
            }
            avg = total / 5;

            stud.getdata( name , roll , total, avg );
            stud.displaydata();
            Console.ReadKey();

            

        }
    }
}
