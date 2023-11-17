using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Polymorphism
{
    class Account
    {
        public int Acc;
        public int Balance=10;

        public virtual string deposite(int Acc , int Amount)
        {
           return"deposit method of account class";
        }
        public string showbalance()
        {
            return "balance amount : " + Balance;
        }

    }
    class Current : Account
    {
        public override string deposite(int Acc, int Amount)
        {
            this.Acc= Acc;
            Balance = Balance + Amount;
            return"Amount Deposited";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account c = new Current();
            string res= c.deposite(11,8000);
            Console.WriteLine("Accno is : " + c.Acc);
            Console.WriteLine(res);
            res = c.showbalance();
            Console.WriteLine(res);

            Console.ReadKey();
            
        }
    }
}
