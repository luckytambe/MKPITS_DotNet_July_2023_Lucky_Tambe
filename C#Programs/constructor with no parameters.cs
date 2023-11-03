using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class book
        {
             int bookid;
            string author, title;
            int price;

            public book()
            {
                bookid = 1;
                author = "Pushpa";
                title = "Mahobbat";
                price = 1000;
            }
                public void displaydata()
             {
                    Console.WriteLine("Bookied :" + bookid);
                    Console.WriteLine("Author :"+ author);
                    Console.WriteLine("Title :"+ title);
                    Console.WriteLine("Price :" + price);
             }
                  
        }

        static void Main(string[] args)
        {
            book book1 = new book();
            book1.displaydata();
            Console.ReadKey();

        }
    }
}
