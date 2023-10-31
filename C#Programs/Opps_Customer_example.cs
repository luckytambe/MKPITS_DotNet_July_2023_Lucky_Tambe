using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Customer_example
{
    internal class Program
    {
        class Customer
        {
            int Customer_code;
            string customer_name;

            public void getdata(int cc, string sn)
            {
                Customer_code = cc;
                customer_name = sn;

            }
            public void displaydata()
            {
                Console.WriteLine(" Code is " + Customer_code);
                Console.WriteLine("Cust name =" + customer_name);
            }

        }
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.getdata( 123 ,  "lucky");
            cust.displaydata();
            Console.ReadKey();
        }
    }
}
