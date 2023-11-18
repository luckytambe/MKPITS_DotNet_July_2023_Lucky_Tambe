using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Example
{
    class Account
    {
        public int Accno;
        public int banalce=11;

        public virtual string deposite(int accno , int Amount)
        {
            return "deposit method of account class";
        }
        public string showbalance()
        {
            return "Balance Amt " + banalce;
        }
    }

    class current : Account
    {
        public override string deposite(int accno, int Amount)
        {
            this.Accno = accno;
            banalce= banalce+Amount;
            return "amount deposited successfully in current class";
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Account a = new current();
            string res = a.deposite(123, 8000);
            Console.WriteLine("Account no is" + a.Accno);
            Console.WriteLine(res);
            res = a.showbalance();
            Console.WriteLine(res);

            Console.ReadKey();



        }
    }
}
