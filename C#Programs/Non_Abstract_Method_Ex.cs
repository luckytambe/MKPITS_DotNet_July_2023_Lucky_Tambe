using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Abstract_Method_Ex
{
    abstract class Account
    {
        public abstract void deposit(); //Non Abstract class 

        public void showbalance()
        {
            Console.WriteLine("From Showbalance");
        }
    }
      class Current : Account
        {
            public override void deposit()
            {
                Console.WriteLine("Hello from Current deposite method");
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
