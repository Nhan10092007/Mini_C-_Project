using System;

namespace BankManagement
{
    abstract class Account
    {
        protected string _id = "";
        protected string _owner = "";
        protected double _balance = 0.0;

        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw  new Exception("Invalid format for account's id!");
                }
                _id = value;
            }
        }
        public string Owner
        {
            get
            {
                return _owner;
            }
            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw  new Exception("Invalid format for account's owner!");
                }
                _owner = value;
            }
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
            protected set
            {
                if(value < 0.0)
                {
                    throw new Exception("Invalid value for account's balance!");
                }
                _balance = value;
            }
        }
        public abstract void Withdraw(double amount);
        public void Deposit(double amount)
        {
            if(amount < 0.0)
            {
                throw new Exception("Invalid value for deposit action!");
            }
            _balance += amount;
            Console.WriteLine($"You have received {amount} USD, your total balance now: {_balance}");
        }
    }
}