using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//wap to accept 5 subject marks using for loop calculate total, per and grade

namespace For_Grade_sum_Per_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num= 5;
            int total = 0;
            float per = 0;
            string grade;

            for (int counter= 1; counter <= 5; counter++)
            {
                Console.WriteLine("Enter Five SubJect Marks : ");
                num = Convert.ToInt32(Console.ReadLine());

                total = total + num;
                per = (total / 500.0f) * 100.0f;
            }

            grade = Convert.ToString(Console.ReadLine());

            if (per >= 75 )
            {
                grade = "Topper";
            }
            else if ( per > 60 && per < 75)
            {
                grade = "First";
            }
            else if (per > 40 && per < 60)
            {
                grade = "Second";
            }
            else
            {
                grade = "Fail";
            }

            Console.WriteLine("Total Marks = " + total);
            Console.WriteLine("Per is = {0}", per);
            Console.WriteLine("grade is :{0}", grade);


            Console.ReadKey();
        }
    }
}
