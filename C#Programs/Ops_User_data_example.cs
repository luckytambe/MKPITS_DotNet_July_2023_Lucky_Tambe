using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops_User_data_example
{
    internal class Program
    {
        class Customer
        {
            int customer_code;
            string customer_name;
            
            public void getdata(int customer_code , string customer_name)
            {
                this.  customer_code = customer_code;
                this .customer_name = customer_name;
            }
            public void displaydata()
            {
                Console.WriteLine("Customer name = " + customer_name);
                Console.WriteLine("Customer code = " + customer_code);
            }

        }
        static void Main(string[] args)
        {
            Customer cust=new Customer();
            Console.WriteLine("Enter Customer Name And Code");
            int custo_code = Convert.ToInt32 (Console.ReadLine());
            string custo_name = Convert.ToString(Console.ReadLine());
            cust.getdata(custo_code, custo_name);
            cust.displaydata();
            Console.ReadKey();
        }
    }
}
