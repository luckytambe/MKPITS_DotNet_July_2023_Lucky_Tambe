using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Overloading
{
    class book
    {
        string title;
        string author ;
        int publicationyear= 2023;

        public void getbook(string  title, string author, int publicationyear)
        {
            this.title = title;
            this.author = author;
            this.publicationyear = publicationyear;
        }

        public void displaybook()
        {
            Console.WriteLine("Title is : " +  title);
            Console.WriteLine("Author is : " +  author);
            Console.WriteLine("publicationYear : " + publicationyear);
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            book b = new book();
            b.getbook("Student Of year", "raju" , 2014);
            b.displaybook();
            Console.ReadKey();

        }
    }
}
