using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_bank_Switch_bank
{
    interface bank
    {
        void deposit(int accno, int amount);
    }

    class saving : bank 
    {
        public int accno;
        public int balance = 500;
        public void deposit(int accno, int amount) 
        {
            this.accno = accno;
            balance = balance + amount;
            
            Console.WriteLine("The Account balance is without intrest  Account number is {0} And balance is  {1} ",accno,balance);
        }

    }
    class current : bank
    {
        public int accno;
        public int balance = 500;
        public void deposit(int accno, int amount)
        {
            int intrest = 200;
            this.accno = accno;
            balance = balance + amount + intrest ;

            Console.WriteLine("The Account balance is without intrest Account number is {0} And balance is  {1} ", accno, balance ,intrest);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bank b = null ;
            Console.WriteLine("Chose is Account Saving or Current");
            string acctype = Console.ReadLine();

            if(acctype =="saving")
            {
                b= new saving();
            
            }
            else if (acctype =="current")
            {
                b = new saving();     
            }

            b.deposit(101,1000);
            Console.ReadKey();

        }
    }
}
