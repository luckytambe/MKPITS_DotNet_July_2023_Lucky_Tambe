using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2- create a class book and constructor with no parameters and another constructor with 4 parameters
namespace No_parameters__another_constructor_with_4_parameters
{
    class book
    {
        public int Bookid;
        public string title;
        public string Author;
        public int price;

        public book()
        {
            Bookid = 1;
            title = "Strangers";
            Author = "Najumuddin";
            price = 420;
        }

        public book(int bookid,string title , string Author , int price)
        {
            this .Bookid = bookid;
            this.title= title;
            this.Author = Author;
            this.price = price;
        }

        public void displaydata()
        {
            Console.WriteLine("Book Id = "+ Bookid);
            Console.WriteLine("Title = " + title);
            Console.WriteLine("Author = "+ Author);
            Console.WriteLine("Price = "+ price);
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            book boo = new book();
            boo.displaydata();

            book boo1= new book(45, "Nalasupara", "Prajapati", 300);
            boo1.displaydata( );
            Console.ReadKey();
        }
    }
}
