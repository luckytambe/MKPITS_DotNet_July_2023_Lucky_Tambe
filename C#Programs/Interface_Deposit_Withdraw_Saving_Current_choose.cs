using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Deposit_Withdraw_Saving_Current_choose
{
    interface Bank
    {
        string Deposit(int Accountno, int Amount);

        string withdraw(int Accountno, int Amount);
    }

    class Saving : Bank
    {
        public int Accountno;
        public int Balance = 1000;
        public string Deposit(int Accountno, int Amount)
        {
            int intrest = 100;
            this.Accountno = Accountno;
            Balance = Balance + Amount + intrest;

            return "The Amount with Intrest is Account number is " + Accountno + " Balance " + Balance;
        }

        public string withdraw(int Accountno, int Amount)
        {
            this.Accountno = Accountno;
            Balance = Balance - Amount;

            return "The Withdraw Amount Without Intrest is Account number is " + Accountno + " Balance " + Balance;
        }
    }

    class Current : Bank
    {
        public int Accountno;
        public int Balance = 1000;
        public string Deposit(int Accountno, int Amount)
        {
            this.Accountno = Accountno;
            Balance = Balance + Amount;

            return "The Amount with Intrest is Account number is " + Accountno + " Balance " + Balance;
        }

        public string withdraw(int Accountno, int Amount)
        {
            this.Accountno = Accountno;
            Balance = Balance - Amount;

            return "The Withdraw Amount Without Intrest is Account number is " + Accountno + " Balance " + Balance;
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b = null;
            Console.WriteLine("Choose Saving or current");

            string attype = Console.ReadLine();

            switch ( attype )
            {
                case"saving":
                    b = new Saving ();
                    break;

                case "current":
                    b = new Current ();
                    break;
            }

            Console.WriteLine("Choose deposit or withdraw");
            string tt = Console.ReadLine ();
            switch ( tt )
            {
                case "deposit":
                   string res=  b.Deposit(123,1000);
                   Console.WriteLine (res);
                    break;

                case "withdraw":
                    string res1 = b.withdraw(123, 1000);
                    Console.WriteLine(res1);
                    break;

            }

            Console.ReadKey();

        }
    }
}
