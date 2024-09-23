using BankingSystem;
using Practical_8_1;

namespace LambdaGenerics_8._1C
{
    internal class Tester
    {
        static void Main(string[] args)
        {
            // Create a MyStack for Account objects with a capacity of 5
            MyStack<Account> accountStack = new MyStack<Account>(5);

            // Adding accounts to the stack (hard-coded)
            accountStack.Push(new Account(150.50m, "John")); // Adding m to number to set number as decimal instead of default double
            accountStack.Push(new Account(500.75m, "Alice"));
            accountStack.Push(new Account(75.00m, "Bob"));
            accountStack.Push(new Account(300.00m, "Charlie"));
            accountStack.Push(new Account(0.00m, "Credit Card"));

            // Find an account with a specific balance (exists)
            Account foundAccount = accountStack.Find(a => a.Balance == 500.75m);
            Console.WriteLine($"Found account with balance 500.75: {foundAccount?.Name}, Balance: {foundAccount?.Balance}");

            // Find an account with a specific balance (does not exist)
            foundAccount = accountStack.Find(a => a.Balance == 1000.00m);
            Console.WriteLine($"Found account with balance 1000.00: {foundAccount?.Name ?? "None"}");

            // Find the first account with a strictly positive balance
            foundAccount = accountStack.Find(a => a.Balance > 0);
            Console.WriteLine($"First account with positive balance: {foundAccount?.Name}, Balance: {foundAccount?.Balance}");

            // Find the first account with a strictly positive balance but not exceeding $100
            foundAccount = accountStack.Find(a => a.Balance > 0 && a.Balance <= 100);
            Console.WriteLine($"First account with positive balance <= 100: {foundAccount?.Name}, Balance: {foundAccount?.Balance}");

            // FindAll accounts with a specific balance
            Account[] foundAccounts = accountStack.FindAll(a => a.Balance == 75.00m);
            Console.WriteLine("Accounts with balance 75.00:");
            if (foundAccounts != null)
            {
                foreach (var account in foundAccounts)
                {
                    Console.WriteLine($"{account.Name}, Balance: {account.Balance}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            // FindAll accounts related to credit cards (using Name property)
            foundAccounts = accountStack.FindAll(a => a.Name.Contains("Credit Card"));
            Console.WriteLine("Accounts related to Credit Cards:");
            if (foundAccounts != null)
            {
                foreach (var account in foundAccounts)
                {
                    Console.WriteLine($"{account.Name}, Balance: {account.Balance}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            // FindAll accounts related to a balance and name
            foundAccounts = accountStack.FindAll(a => a.Balance > 100 && a.Name == "Alice");
            Console.WriteLine("Accounts with balance > 100 and name Alice:");
            if (foundAccounts != null)
            {
                foreach (var account in foundAccounts)
                {
                    Console.WriteLine($"{account.Name}, Balance: {account.Balance}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            // Test Max method to find the account with the highest balance
            try
            {
                Account maxAccount = accountStack.Max();
                Console.WriteLine($"Max account: {maxAccount?.Name}, Balance: {maxAccount?.Balance}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Test Min method to find the account with the lowest balance
            try
            {
                Account minAccount = accountStack.Min();
                Console.WriteLine($"Min account: {minAccount?.Name}, Balance: {minAccount?.Balance}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // RemoveAll accounts with a balance > 100
            int removedCount = accountStack.RemoveAll(a => a.Balance > 100);
            Console.WriteLine($"Removed {removedCount} accounts with balance > 100.");

            // Check remaining accounts in the stack after removal
            Console.WriteLine("Remaining accounts in the stack:");
            for (int i = accountStack.Count - 1; i >= 0; i--)
            {
                var account = accountStack.Pop();
                Console.WriteLine($"{account.Name}, Balance: {account.Balance}");
            }
        }
    }
}
