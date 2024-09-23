using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Account : IComparable<Account>
    {
        // Declaring variables
        private decimal _balance;
        private String _name;

        // Property
        public String Name
        {
            get { return _name; }
        }

        public decimal Balance
        {
            get { return _balance; }
        }

        // Constructor
        public Account(decimal balance, string name)
        {
            this._balance = balance;
            this._name = name;
        }

        // Methods
        public Boolean Deposit(decimal amount)
        {
            if (amount > 0) // check if amount is more than zero
            {
                this._balance += amount;
                Console.WriteLine($"{amount.ToString("C")} deposited. Your current balance is now {this._balance.ToString("C")}.");
                return true;
            }
            else // case if amount is less or equal to zero
            {
                Console.WriteLine("Deposit unsuccessful. Invalid amount.");
                return false;
            }
        }

        public Boolean Withdraw(decimal amount)
        {
            if (amount > 0) // check if amount is more than zero
            {
                if ((this._balance - amount) >= 0) // check if after withdrawal balance is zero or more
                {
                    this._balance -= amount;
                    Console.WriteLine($"{amount.ToString("C")} withdrawn. Your current balance is now {this._balance.ToString("C")}.");
                    return true;
                }
                else // case if with withdrawal balance is negative
                {
                    Console.WriteLine("Withdrawal unsuccessful. You do not have enough funds for the withdrawal.");
                    return false;
                }
            }
            else // case if amount is less or equal to zero
            {
                Console.WriteLine("Withdrawal unsuccessful. Invalid amount.");
                return false;
            }
        }

        public void Print()
        {
            Console.WriteLine("\n--- Account Details ---");
            Console.WriteLine("Name Under: " + this._name);
            Console.WriteLine("Balance: " + this._balance.ToString("C"));
            Console.WriteLine("-----------------------\n");
        }

        // Implementing IComparable for sorting accounts by balance
        public int CompareTo(Account other)
        {
            if (other == null) return 1;
            return this._balance.CompareTo(other._balance);
        }
    }
}
