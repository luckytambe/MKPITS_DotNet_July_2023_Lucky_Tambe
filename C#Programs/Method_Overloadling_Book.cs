using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloadling_Book
{
    class Book
    {
        int id;
        string name;
        string title;
        int price;

         public void getdata ()
        {
            id = 1;
            name = "Lucky";
            title = "Gans Of Wasepur";
            price = 1500;
         
        }

        public void getdata( int id , string name, string title , int price )
        {
            this.id = id;
            this.name = name;
            this.title= title;  
            this.price = price;
        }

        public void display()

        {
            
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Title : " + title);
            Console.WriteLine("price : " + price);
        }    
    
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Book One Detail------");
            Book b1= new Book();
            b1.getdata();
            b1.display();

            Console.WriteLine("------Book Two Detail------");

            Book b2= new Book();
            b2.getdata(2, "Akash","Justic",520);
            b2.display();

            Console.WriteLine("------Enter book Three Detail------");

            Console.WriteLine("Enter Id");
            int id= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENter NAme");
           string name= Convert.ToString(Console.ReadLine());

            Console.WriteLine("ENter title");
            string title = Convert.ToString(Console.ReadLine());

            Console.WriteLine("ENter Price");
            int price= Convert.ToInt32(Console.ReadLine());

            

            Book b3= new Book();
            b3.getdata(id,name,title,price);
            b3.display();
            

            Console.ReadKey();




            Console.ReadKey();
        }
    }
}
