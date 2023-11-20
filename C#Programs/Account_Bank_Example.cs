using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Account_Bank_Example
{
    abstract class Account
    {
        public int Accno;
        public int balance = 1000;
        public abstract void deposit(int amt);

        public void showbalance()
        {
            Console.WriteLine("Balance Of Amount is {0} to {1} ", Accno,balance);
        }

    }

    class current : Account
    {
        public override void deposit(int amt)
        {
            balance = balance + amt;
        }
    }

    class saving : Account
    {
        public override void deposit(int amt)
        {
            int intrest = 500;
            balance = balance + amt + intrest;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account Number");
            int Accno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Amount Deposit");
            int amt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter account type saving or current");
            string acttype = Console.ReadLine();

            Account act = null;
            if (acttype == "saving")
            {
                act = new saving();
            }
            else if (acttype == "current")
            {
                act = new current();
            }
            act.Accno = Accno;
            act.deposit(amt);
            act.showbalance();
            

            Console.ReadKey();

        }
    }
}
