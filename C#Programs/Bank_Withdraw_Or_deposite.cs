using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Withdraw_Or_deposite
{
    abstract class Account
    {
        public int balance = 1000;
        public abstract void deposit(int amt);
        public abstract void withdraw(int amt);

        public void showbalance()
        {
            Console.WriteLine("Balance is : " + balance);
        }
    }

    class saving : Account
    {
        public override void withdraw(int amt)
        {
            balance = balance + amt;
        }

        public override void deposit(int amt)
        {
            int intrest = 500;
            balance = balance + amt + intrest;
            Console.WriteLine("Balance With intrest : " + balance);
        }
    }

    class current : Account
    {
        public override void withdraw(int amt)
        {
           balance = balance - amt;
        }

        public override void deposit(int amt)
        {
            balance = balance * amt;
            Console.WriteLine("Balance Without Intrest is : " + balance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act = null;

            Console.WriteLine("Enter Account Number : ");
            int Accno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter balance : ");
            int balance = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Saving or current");
            string acctype = Console.ReadLine();

            Console.WriteLine("Enter deposit or Withdraw");
            string tt = Console.ReadLine();

            if( acctype=="saving")
            {
               act = new saving ();
            }
            else if (acctype=="current")
            {
                act = new current ();
            }

            if (tt=="deposit")
            {
                act.deposit(balance);
            }
            if(tt=="Withdraw")
            {
                act.withdraw(balance);
            }

            act.showbalance();

            Console.ReadKey();

            
        }
    }
}
