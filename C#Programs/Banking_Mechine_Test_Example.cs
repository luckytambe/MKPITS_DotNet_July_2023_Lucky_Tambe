using System;
using System.Collections.Generic;

class Account
{
    public string AccountNumber { get; }
    public decimal Balance { get; private set; }

    public Account(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount:C} into account {AccountNumber}. New balance: {Balance:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (Balance - amount >= 0)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount:C} from account {AccountNumber}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine($"Insufficient funds in account {AccountNumber}.");
        }
    }
}

class Customer
{
    public string Name { get; }
    private List<Account> accounts = new List<Account>();

    public Customer(string name)
    {
        Name = name;
    }

    public void AddAccount(Account account)
    {
        accounts.Add(account);
    }

    public decimal GetTotalBalance()
    {
        decimal totalBalance = 0;
        foreach (var account in accounts)
        {
            totalBalance += account.Balance;
        }
        return totalBalance;
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine($"Customer: {Name}");
        foreach (var account in accounts)
        {
            Console.WriteLine($"Account: {account.AccountNumber}, Balance: {account.Balance:C}");
        }
        Console.WriteLine($"Total Balance: {GetTotalBalance():C}");
    }
}

class Bank
{
    private List<Customer> customers = new List<Customer>();

    public void AddCustomer(Customer customer)
    {
        customers.Add(customer);
    }

    public void Deposit(string customerName, string accountNumber, decimal amount)
    {
        var customer = FindCustomer(customerName);
        if (customer != null)
        {
            var account = FindAccount(customer, accountNumber);
            if (account != null)
            {
                account.Deposit(amount);
            }
        }
    }

    public void Withdraw(string customerName, string accountNumber, decimal amount)
    {
        var customer = FindCustomer(customerName);
        if (customer != null)
        {
            var account = FindAccount(customer, accountNumber);
            if (account != null)
            {
                account.Withdraw(amount);
            }
        }
    }

    public void DisplayCustomerAccountDetails(string customerName)
    {
        var customer = FindCustomer(customerName);
        if (customer != null)
        {
            customer.DisplayAccountDetails();
        }
    }

    private Customer FindCustomer(string customerName)
    {
        return customers.Find(c => c.Name.Equals(customerName, StringComparison.OrdinalIgnoreCase));
    }

    private Account FindAccount(Customer customer, string accountNumber)
    {
        return customer != null ? customer.GetAccounts().Find(a => a.AccountNumber.Equals(accountNumber, StringComparison.OrdinalIgnoreCase)) : null;
    }
}

class Program
{
    static void Main()
    {
        // Create a bank
        Bank myBank = new Bank();

        // Create customers
        Customer johnDoe = new Customer("John Doe");
        Customer janeSmith = new Customer("Jane Smith");

        // Add customers to the bank
        myBank.AddCustomer(johnDoe);
        myBank.AddCustomer(janeSmith);

        // Create accounts for customers
        Account johnAccount1 = new Account("001", 1000);
        Account johnAccount2 = new Account("002", 500);
        Account janeAccount1 = new Account("101", 1500);

        // Add accounts to customers
        johnDoe.AddAccount(johnAccount1);
        johnDoe.AddAccount(johnAccount2);
        janeSmith.AddAccount(janeAccount1);

        // Perform transactions
        myBank.Deposit("John Doe", "001", 200);
        myBank.Withdraw("John Doe", "002", 100);
        myBank.Deposit("Jane Smith", "101", 300);

        // Display account details
        myBank.DisplayCustomerAccountDetails("John Doe");
        myBank.DisplayCustomerAccountDetails("Jane Smith");
    }
}
