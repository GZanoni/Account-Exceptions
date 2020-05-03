using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Conta_Excecoes.Entities
{
    class Account
    {

        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new Exception("The amount exceeds withdraw limit");
            }

            else if (amount > Balance)
            {
                throw new Exception("Not enough balance");
            }
            else
            {
                Balance -= amount;
            }

        }

        public override string ToString()
        {
            return "New balance: " + Balance;
        }

    }
}
