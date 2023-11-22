using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AssignMent_Keyword
{
    public class book
    {
        public string title { get; set; }
        public int pages { get; set; }
        public string author { get; set; }

    }

    class Bookie : book
    {
        public void getdata(string title, int pages, string author)
        {
            this.title = title;
            this.pages = pages;
            this.author = author;
        }

        public void display()
        {
            Console.WriteLine("title  : " + title);
            Console.WriteLine("pages  ; " + pages);
            Console.WriteLine("Author   ; " + author);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            book b = new book();
            b.title = "Gang Of Wasepurr";
            b.author = "Sarang";
            b.pages = 40;

            Console.WriteLine("Title : " + b.title);
            Console.WriteLine("Author : " + b.author);
            Console.WriteLine("Pages : " + b.pages);

            Console.ReadKey();  
        }
    }
}
