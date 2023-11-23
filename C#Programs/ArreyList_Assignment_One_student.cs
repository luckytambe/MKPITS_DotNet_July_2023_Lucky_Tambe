using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreyList_Assignment_One_student
{
    class Employe
    {
        public int Eno;
        public string Name;
        public int salary;
        public string designation;

        public Employe (int  Eno, string Name, int salary , string designation)
        {
            this.Eno = Eno;
            this.Name = Name;
            this.salary = salary;
            this.designation = designation;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(1);
            ar.Add("lucky");
            ar.Add(5000);
            ar.Add("Manager");
            Console.WriteLine("----Employe Details----");
            foreach (object Std in ar)
            {
                 Console.WriteLine(Std);
            }
            Console.ReadKey();

        }
    }
}
