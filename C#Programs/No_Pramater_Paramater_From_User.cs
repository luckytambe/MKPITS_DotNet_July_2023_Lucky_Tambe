using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace With_Pramater_Paramater_From_User
{
    class Bank
    {
        public int CustomerId;
        public string CustomerName;
        public int AccountNo;
        public int balance;

        public Bank( int CustomerId , string CustomerName , int AccountNo , int balance) 
        {
            this.CustomerId = CustomerId;
            this.CustomerName = CustomerName;
            this.AccountNo = AccountNo;
            this.balance = balance;
        }
        public void display()
        {
            Console.WriteLine("Customer Id : " + CustomerId);
            Console.WriteLine("Customer Name : "+ CustomerName);
            Console.WriteLine("Account No : "+AccountNo);
            Console.WriteLine("Balance : " + balance);
        }


    
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Customer Id : ");
            int id=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Customer Name : : ");
            string na=Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Account No : ");
            int Acc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Balance : ");
            int bal = Convert.ToInt32(Console.ReadLine());

            Bank baa = new Bank(id, na,Acc, bal);
             baa.display();
            Console.ReadKey();



        }
    }
}
