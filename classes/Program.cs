using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Ben Nesbit", 42069);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

/*
            account.MakeWithdrawal(500, DateTime.Now, "Rent Payment.");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back.");
            Console.WriteLine(account.Balance);
*/  
            // Test that the initial balance must be positive
            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Excpetion caught creating account with negative balance.");
                Console.WriteLine(e.ToString());
            }
        }
    }
}
