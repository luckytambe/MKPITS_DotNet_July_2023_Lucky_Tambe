using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Balance_amt_example
{
    internal class Program
    {
        static void Amount( int amt)
        {
            int balance = 1000;
            balance= balance + amt;
            Console.WriteLine("Deposite is = " + balance);

            balance = balance - amt;
            Console.WriteLine("Withdrawl is = " + balance);
        }
        static void Main(string[] args)
        {
            int Amt;
            int accno;
            Console.WriteLine("Enter Accno");
            accno=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter amount");
            Amt=Convert.ToInt32(Console.ReadLine());

            Amount(Amt);
            Console.ReadKey();
            
        }
    }
}
