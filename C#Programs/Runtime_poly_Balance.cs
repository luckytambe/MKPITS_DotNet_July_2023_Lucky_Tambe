using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_poly_Balance
{
    class Account
    {
        public int Accno;
        public int Balance = 500;

        public virtual string deposite(int Accno, int Amount)
        {
            return "Account balance Submit";
        }
        public string showbalance()
        {
            return "Balance Account "+Balance;
        }
    }

    class Current : Account 
    {
        public override string deposite(int Accno, int Amount)
        {
            this.Accno = Accno;
            Balance=Balance+Amount;
            return "amount deposited successfully in current class";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account c = new Current();
            string res = c.deposite(123, 2000);
            Console.WriteLine(res);
            res = c.showbalance();
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
