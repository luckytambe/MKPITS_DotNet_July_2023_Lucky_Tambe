using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//program to accept 5 subject marks in an array then display total, percentage and grade
namespace Five_sub_marks_grade_Per_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int sum = 0;
            float per = 0;
            string grade = null;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Five Subject marks : ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                sum = sum + num[i];   
            }
            Console.WriteLine("sum = " + sum);

             per = (sum / 500.0f) * 100.0f;
            Console.WriteLine("per is  = "+ per);
            
                if (per > 75)
                {
                    grade = "Topper";
                }
                else if (per < 50 && per > 75)
                {
                    grade = "grade A";
                }
                else
                {
                grade = "fail";
                }
                Console.WriteLine("grade is = " + grade);

                Console.ReadKey();
            
        }
        
        
    }
}

