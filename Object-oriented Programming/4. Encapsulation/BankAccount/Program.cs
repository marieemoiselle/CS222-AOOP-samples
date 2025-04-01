using System;

class BankAccount
{
    private string accountNumber;
    private string accountHolder;
    private decimal balance;

    public BankAccount(string accountNumber, string accountHolder, decimal initialBalance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive.", nameof(amount));
        }
        balance += amount;
        Console.WriteLine($"Deposited: {amount}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.", nameof(amount));
        }
        if (amount > balance)
        {
            throw new InvalidOperationException("Insufficient funds for withdrawal.");
        }
        balance -= amount;
        Console.WriteLine($"Withdrew: {amount}");
    }

    public void PrintBalance()
    {
        Console.WriteLine($"Account Balance: {balance}");
    }

    public string AccountNumber => accountNumber;
    public string AccountHolder => accountHolder;
    public decimal Balance => balance;
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("123456789", "John Doe", 1000.00m);
        account.PrintBalance();
        account.Deposit(500);
        account.Withdraw(200);
        account.PrintBalance();
        
        try
        {
            account.Withdraw(2000);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}