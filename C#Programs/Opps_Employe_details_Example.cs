using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Employe_details_Example
{
    internal class Program
    {
        class Employe
        {
            string  emp_name , designation ;
            int sallery;

            public void getdata(string name, string desi, int sal)
            {
                emp_name = name;
                designation = desi;
                sallery = 100000;
            }
            public void displaydata()
            {
                Console.WriteLine("EmpName = " + emp_name);
                Console.WriteLine("desination = "+ designation);
                Console.WriteLine("Sallery =" +  sallery);
            }
            

        }

        static void Main(string[] args)
        {

            Employe emp = new Employe();
            emp.getdata("Akash","Ceo",50000);
            emp.displaydata();
            Console.ReadKey();
        }
    }
}
