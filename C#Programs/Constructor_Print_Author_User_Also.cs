using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Print_Author_User_Also
{
    class Book
    {
        int bookid,price;
        string author,title;

        public Book()
        {
            bookid = 1;
            price = 200;
            author = "Sarang";
            title = "Oxford";
        }
        public Book( int bookid, int price,string  author, string title )
        {
            this.bookid = bookid;
            this.price = price;
            this.author = author;
            this.title = title;
        }

        public void display()
        {
            Console.WriteLine("Bookid : " + bookid);
            Console.WriteLine("price : "+ price);
            Console.WriteLine("author :"+ author);
            Console.WriteLine("title : " + title);
        }

    
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------BooK One Details-------------");

            Book b= new Book();
            b.display();

            Console.WriteLine("-----------book Two Details---------------");

            Book b1 = new Book(2, 350, "Akash", "Placements");
            b1.display();

            Console.WriteLine("-----------Enter Three Details---------------");

            Console.WriteLine("Enter Bookid :");
            int id =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Price: ");
            int pr =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Author: ");
            string Au=Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter title: ");
            string ti = Convert.ToString(Console.ReadLine());

            Console.WriteLine("-----------book Three Details---------------");
            Book b2= new Book( id,pr,Au,ti);
            b2.display();
           

            Console.ReadKey();  
        }
    }
}
