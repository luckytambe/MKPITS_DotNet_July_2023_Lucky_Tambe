using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrey_Opps_Example1
{
    internal class Program

    {
        class Customer
        {
         public   int Customer_Code;
          public  String Customer_Name;
        }

        static void Main(string[] args)
        {
            Customer Cust= new Customer();

            Cust.Customer_Code = 1;
            Cust.Customer_Name = "Akash";

            Console.WriteLine("Customer Code = " +  Cust.Customer_Code);
            Console.WriteLine("Customer Name = " + Cust.Customer_Name);
            Console.ReadKey();
        }
        
    }
}
