using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_With_Method_Bank
{
    interface bank
    {
        string deposit(int Accno, int balance);
   
    }

    class saving : bank
    {
        public int Accno;
        public int balance = 1000;
        
        public string deposit(int Accno , int amt)
        {
            this.Accno = Accno;
            balance = balance + amt;
            return "balance : " + balance;

        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            bank b;
            b = new saving();

           string str= b.deposit (123,400);
            Console.WriteLine(str);

            Console.ReadKey();
           
        }
    }
}
