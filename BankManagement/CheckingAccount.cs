using System;

namespace BankManagement
{
    class CheckingAccount: Account
    {
        public CheckingAccount(string id, string owner_name, double initial_balance)
        {
            ID = id;
            Owner = owner_name;
            Balance = initial_balance;
        }
        public override void Withdraw(double amount)
        {
            if(amount <= 0.0)
            {
                throw new Exception("Invalid value for withdraw's amount!");
            }
            if(_balance < amount)
            {
                throw new Exception("You don't have enough money to withdraw");
            }
            Balance -= amount;
            Console.WriteLine($"You have successfully withdraw {amount} USD. Your balance now: {_balance}");
        }
    }
}