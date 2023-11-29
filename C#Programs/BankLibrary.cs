using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankLibrary;

namespace BankLibrary
{
    public abstract class  Account 
    {
        public int Accno;
        public int balance = 1000;

        public abstract string deposit(int Accno, int amount);
        public abstract string withdraw(int Accno, int amount);

            public string Show()
            {
                return "the amount is : " + balance.ToString();
            }
        
    }

    public class saving : Account
    {
        public override string deposit(int Accno, int amount)
        {
            int intrest = 500;
            balance = balance + amount  + intrest;
            return " Amount deposited successfully \n" + "Available balance for Account number  " + Accno + " balance is " + balance.ToString();
        }

        public override string withdraw(int Accno, int amount)
        {
            string res = null;
            if (balance < amount)
            {
                res = " Insufficiant balance ";
            }
            else
            {
                balance = balance - amount;
                res = " Amount Withdrawl successfully \n" + "Available balance for Account number  " + Accno + " balance is " + balance.ToString();

            }

            return res;

        }
    }
    }

    public class current : Account
    {
        public override string deposit (int Accno, int amount)
        {
            balance = balance + amount;
             return " Amount deposited successfully \n" + "Available balance for Account number  " + Accno + " balance is " + balance.ToString();
        }

        public override  string withdraw(int Accno, int amount)
        {
        string res = null;
        if (balance < amount)
        {
            res = " Insufficiant balance ";
        }
        else
        {
            balance = balance - amount;
            res = " Amount withdraw successfully \n" + "Available balance for Account number  "  + Accno + " balance is " +balance.ToString();

        }

        return res;

    }
}
