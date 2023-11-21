using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_With_method_bankEx2
{
    interface Bank
    {
        string deposit(int Accno, int balance);
    }

    class saving : Bank
    {
        public int Accno;
        public int balance;
        public string deposit(int Accno , int Amt)
        {
            int intrest = 200;
            this.Accno = Accno;
            balance = balance + Amt + intrest;
            return "Balance with intrest is  : " + balance ;
        }
    }

    class current : Bank
    {
        public int Accno;
        public int balance ;

        public string deposit( int Accno , int Amt )
        {
            this.Accno = Accno;
            balance = balance + Amt;
            return " Balance Without intrest is : " + balance;
        }
    }


    internal class Program 
    {
        static void Main(string[] args)
        {
            Bank b; 
            b = new saving ();
            string res = b.deposit(123, 200);



            b = new current();
            string res1 = b.deposit(123, 200);

            Console.WriteLine(res);
            Console.WriteLine(res1);

            Console.ReadKey();
        }
    }
}
