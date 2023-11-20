using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankExample_With_return
{
    abstract class Account
    {
        public int Accno;
        public int balance = 1000;

        public abstract string deposit(int Accno, int amt);

         public string showbalance()
        {
            return "Balance is " + balance;
        }
    }

    class current : Account
    {
        public override string deposit(int Accno, int amt)
        {
            this.Accno = Accno ;
            balance = balance + amt;
            return "The balance without intrest " + balance;
        }
    }
    class saving : Account
    {
        public override string deposit(int Accno, int amt)

        {
            this.Accno = Accno;
            int intrest = 100;
            balance = amt + balance + intrest;
            return " with intrest balance " + balance;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Accoun number : ");
            int Accno = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Enter Balance");
            int balance = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Saving Or Current");
            string acctype= Console.ReadLine();

            Account act = null;
            if(acctype == "saving")
            {
                act = new saving();
            }
            else if (acctype == "current")
            {
                act = new current();
            }

            string res = act.deposit(Accno,balance);
            Console.WriteLine("Account no is " + act.Accno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);
            Console.ReadKey();  
                
        }
    }
}
