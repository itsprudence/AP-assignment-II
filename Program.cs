Question(c)
﻿// See https://aka.ms/new-console-template for more information


using System;

namespace BankSystem
{
    // Base Account Class
    public abstract class Account
    {
        public int AccountNo { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; protected set; }

        public Account(int accountNo, string holderName, double balance)
        {
            AccountNo = accountNo;
            HolderName = holderName;
            Balance = balance;
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Account No: {AccountNo}, Balance: {Balance:C}");
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New Balance: {Balance:C}");
        }

        public abstract void Withdraw(double amount);
    }

    // Savings Account Class
    public class SavingsAccount : Account
    {
        public double InterestRate { get; private set; }

        public SavingsAccount(int accountNo, string holderName, double balance, double interestRate)
            : base(accountNo, holderName, balance)
        {
            InterestRate = interestRate;
        }

        public override void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance for withdrawal.");
            }
            else
            {
                Balance = Balance - amount;
                Console.WriteLine($"Withdrew {amount:C}. New Balance: {Balance:C}");
            }
        }

        public void EarnInterest()
        {
            double interest = Balance * InterestRate / 100;
            Balance += interest;
            Console.WriteLine($"Interest Earned: {interest:C}. New Balance: {Balance:C}");
        }
    }

    // Current Account Class
    public class CurrentAccount : Account
    {
        public double OverdraftLimit { get; private set; }

        public CurrentAccount(int accountNo, string holderName, double balance, double overdraftLimit)
            : base(accountNo, holderName, balance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override void Withdraw(double amount)
        {
            if (amount > Balance + OverdraftLimit)
            {
                Console.WriteLine("Withdrawal exceeds overdraft limit.");
            }
            else
            {
                Balance = Balance - amount;
                Console.WriteLine($"Withdrew {amount:C}. New Balance: {Balance:C}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a Savings Account
            SavingsAccount savings = new SavingsAccount(101, "Spencer Reid", 5000d, 5d);
            savings.CheckBalance();
            savings.Deposit(1000d);
            savings.Withdraw(2000d);
            savings.EarnInterest();

            // Create a Current Account
            CurrentAccount current = new CurrentAccount(102, "Nia Long", 2000d, 1000d);
            current.CheckBalance();
            current.Deposit(500d);
            current.Withdraw(3000d);
            current.Withdraw(500d); // This should exceed overdraft
=======
﻿using System;

class LibraryBooks
{
    private string name, code;

    public LibraryBooks(string name, string code)
    {
        this.name = name;
        this.code = code;
    }

    public string Name
    {
        get { return name; }
    }

    public string Code
    {
        get { return code; }
    }
}

class GetBooks
{
    static void Main()
    {
        int totalBooks;
        Console.Write("Enter the number of books to store: ");
        totalBooks = int.Parse(Console.ReadLine());

        LibraryBooks[] books = new LibraryBooks[totalBooks];

        for (int i = 0; i < books.Length; i++)
        {
            Console.Write($"Enter name for book {i + 1}: ");
            string name = Console.ReadLine();

            Console.Write($"Enter code for book {i + 1}: ");
            string code = Console.ReadLine();

            books[i] = new LibraryBooks(name, code);
        }

        Console.WriteLine("\nBooks in the Library:");
        Console.WriteLine("-----------------------");
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"Book {i + 1}: Code = {books[i].Code}, Name = {books[i].Name}");
          main
        }
    }
}
