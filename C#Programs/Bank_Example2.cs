using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Example2
{
    abstract class account
    {
        public int Accno;
        public int balance = 1000;
        public abstract void deposit(int amt);

        public void showbalance()
        {
            Console.WriteLine("Balance Amt for Act No is {0} and {1}",Accno, balance);
        }
    }

    class current : account
    {
        public override void deposit(int amt)
        {
            balance = balance + amt;
        }
    }

    class saving : account
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
            Console.WriteLine("Enter Account Number : ");
            int Accno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter balance : ");
            int amt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Type Saving or current ");

            string acctype = Console.ReadLine();

            account act = null;
            if(acctype == "saving")
            {
                act = new saving();
            }

            else if (acctype == "current")
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
