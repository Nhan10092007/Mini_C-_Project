using System;

namespace BankManagement
{
    class SavingAccount: Account
    {
        private int withdrawCount = 3;
        public int WithdrawCount{
            get
            {
                return withdrawCount;
            }
        }
        public SavingAccount(string id, string owner_name, double intial_balance)
        {
            ID = id;
            Owner = owner_name;
            Balance = intial_balance;
        }
        public override void Withdraw(double amount)
        {
            if(withdrawCount <= 0)
            {
                Console.WriteLine("You have exceeded the withdraw count, you can't withdraw now!");
                return;
            }        
            if(amount <= 0.0)
            {
                throw new Exception("Invalid value for withdraw's amount!");
            }
            if(_balance < amount)
            {
                throw new Exception("You don't have enough money to withdraw");
            }
            Balance -= amount;
            --withdrawCount;
            if(withdrawCount > 0)
            {
                Console.WriteLine($"You have successfully withdraw {amount} USD. Your balance now: {_balance}. You only have {withdrawCount} times left.");
            }
            else
            {
                Console.WriteLine($"You have successfully withdraw {amount} USD. Your balance now: {_balance}. You have {withdrawCount} time left, you can't withdraw anymore in this month.");
            }
        }
    }
}