using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreyList_Assignment_Product
{
    class Product
    {
        public int productid;
        public string name;
        public int price;

        public Product( int productid , string name , int price)
        {
            this.productid = productid;
            this.name = name;
            this.price = price;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(1);
            ar.Add("Durex");
            ar.Add(80);

            foreach (object pro in ar)
            {
                Console.WriteLine(pro);
            }

            Console.ReadKey();
        }
    }
}
