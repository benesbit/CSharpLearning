﻿using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Ben Nesbit", 42069);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            // Test Withdrawl and Deposit
            account.MakeWithdrawal(500, DateTime.Now, "Rent Payment.");
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back.");
            Console.WriteLine($"\n");

            Console.WriteLine(account.GetAccountHistory());
/*
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

            // Test for a negative balance
            try
            {
                account.MakeWithdrawal(90000, DateTime.Now, "Attempt to overdraw account.");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw.");
                Console.WriteLine(e.ToString());
            }
*/            
        }
    }
}
