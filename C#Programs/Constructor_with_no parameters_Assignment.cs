using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_with_no_parameters_Assignment
{
    class product
    {
        public int productid;

        public string productname;

        public int price;

        public int quantity;

        public product()

        {
            productid = 1;
            productname = "Durex";
            price = 80;
            quantity = 10;
        }

        public void display ()
        {
            Console.WriteLine(" product Id : "+ productid);
            Console.WriteLine(" ProductName : "+ productname);
            Console.WriteLine(" Price : " + price);
            Console.WriteLine(" Quanttity : "+ quantity);
        }

    }
    internal class Program
    {
     

       
        static void Main(string[] args)
        {
            product pro = new product();
            pro.display();
            Console.ReadKey();
        }
    }
}
