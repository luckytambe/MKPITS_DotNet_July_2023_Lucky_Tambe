using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selead_Class_Ex
{
    interface Bank
    {
        void deposit(string name, int Accno, int Amount);
    }

    class Saving : Bank
    {
        public string name;
        public int Accno;
        public int balance = 100;

        public void deposit(string name , int Accno , int Amount)
        {
           this.name = name;
           this.Accno = Accno;
           balance = balance + Amount;
           Console.WriteLine("Balance = " + balance);
        }

    }
    sealed class Current : Saving
    { 
       
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Saving();
            b.deposit(" lucky ",123, 1000);


            Console.ReadKey();
        }
    }
}
