using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Saving_Deposite_Withdraw_CurrentEx2
{
   
    interface bank
    {
        string deposit(int actno, int amt);
        string withdraw(int actno, int amt);
    }
    class account
    {
        public int actno;
        public int bal = 1000;
        public string showbalance()
        {
            return "bal is " + bal;
        }
    }
    class saving : account, bank
    {

        public string deposit(int actno, int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "deposited successfully successfully ,bal is " + bal;
        }
        public string withdraw(int actno, int amt)
        {
            this.actno = actno;
            bal = bal - amt;
            return "withdraw successfully ,bal is " + bal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            saving b;
            b = new saving();
            String str = b.deposit(1, 200);
            Console.WriteLine(str);

            str = b.withdraw(1, 100);
            Console.WriteLine(str);
            Console.WriteLine(b.showbalance());

            Console.ReadKey();
        }
    }

}
