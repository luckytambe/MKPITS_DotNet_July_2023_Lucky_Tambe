using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Bank_ShowBalance_Example
{
    interface Bank
    {
        string deposit(int Accountno, int Amount);
        string withdraw(int Accountno, int Amount);

        string showbalance();
    }

    class Saving : Bank
    {
        public int Accountno;
        public int balance = 1000;
        int intrest = 200;
        public string deposit (int Accountno , int Amount)
        {
            this.Accountno = Accountno;
            balance = balance + Amount + intrest;
            return " the balance With intrest Account number " + Accountno + " Balance is "+ balance;
        }

        public string withdraw(int  Accountno , int Amount)
        {
            this.Accountno = Accountno;
            balance = balance - Amount;
            return "The Balance deposite Account number "+ Accountno + " balance " + balance;
        }

        public string showbalance()
        {
            return "The Available balance " + balance;
        }
    }

    class Current : Bank
    {
        public int Accountno;
        public int balance = 1000;
        public string deposit(int Accountno, int Amount)
        {
           
            this.Accountno = Accountno;
            balance = balance + Amount;
            return " the balance Without intrest Account number is " + Accountno + " Balance " + balance;
        }

        public string withdraw(int Accountno, int Amount)
        {
            this.Accountno = Accountno;
            balance = balance - Amount;
            return "The Balance deposite Account number " + Accountno + " balance " + balance;
        }

        public string showbalance()
        {
            return "The Available balance " + balance;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b = null;
            Console.WriteLine("Choose Saving or current");

            string attype = Console.ReadLine();

            switch (attype)
            {
                case "saving":
                    b = new Saving();
                    break;

                case "current":
                    b = new Current();
                    break;
            }

            Console.WriteLine("Choose deposit or withdraw");
            string tt = Console.ReadLine();
            if (tt == "deposit")
            {
                string res = b.deposit(123, 500);
                Console.WriteLine(res);
            }

            else if (tt == "withdraw")
            {
                string res = b.withdraw(123, 500);
                Console.WriteLine(res);
            }

            Console.WriteLine(b.showbalance());
            Console.ReadKey();
        }
    }
}
