using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeBonusExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empno;
            int basicsalary;
            float totalsal=0;
            float bonus=0;
            string empname, desi=null;

            Console.WriteLine("Enter Empname : ");
            empname = (Console.ReadLine());

            Console.WriteLine("Enter empno : ");
            empno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter desi : ");
            desi =Console.ReadLine();

            Console.WriteLine("Enter empsalary");
            basicsalary = Convert.ToInt32(Console.ReadLine());

            if (desi == "manager")
            {
                bonus = basicsalary * 0.50f;
            }
            else if (desi == "clerk")
            {
                bonus = basicsalary * 0.25f;
            }
            else if (desi == "peon")
            {
                bonus = basicsalary * 0.10f;
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            totalsal = basicsalary + bonus;

            Console.WriteLine("empname = {0}, empn = {1}, desi = {2} , empsalary = {3}, " , empname  ,  empno   ,   desi  ,  basicsalary );
            Console.WriteLine("bonus = {0}, total salary = {1}", bonus, totalsal);


            Console.ReadKey();
        }
    }
}
