using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Bank_Switch
{
    interface Bank
    {
        string deposit(int Accno, int Amount); // method
    }
    class current : Bank
    {
        public int Accno;
        public int balance;
        public string deposit(int Accno, int Amount)
        {

            this.Accno= Accno;
            balance = balance + Amount;
            return "The Account balance without intrest is : " + balance;

        }
    }
    class saving : Bank
    {
       public int Accno;
       public int balance;

        public string deposit(int Accno, int Amount)
        {
            int intrest = 500;
            this.Accno = Accno;
            balance = balance + Amount +intrest;
            return "The Amount balance With Intrest is : " + balance;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b = null;
            Console.WriteLine("Enter Saving or Current");

            string attype = Console.ReadLine();
            switch (attype)
            {
                case "current":
                    b= new current();
                   string res =  b.deposit(111,100);
                    Console.WriteLine(res);
                    break;

                case "saving":
                    b= new saving();
                   string res1= b.deposit(111, 100);
                    Console.WriteLine(res1);
                    break;

            }


            Console.ReadKey();
            


        }
    }
}
