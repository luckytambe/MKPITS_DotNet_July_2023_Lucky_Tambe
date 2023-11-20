using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Abstract_Calss2
{
    abstract class Account
    {
        abstract public void deposit();        
        public void showbalance()
        {
            Console.WriteLine("The Balance is ");
        }
        
    }

    class Current : Account
    {
        public override void deposit()
        {
            Console.WriteLine("Massage From Current Account");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account A = new Current();
            A.deposit();
            A.showbalance();
            Console.ReadKey();
        }
    }
}
