using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using ExerTratamentoExcecoes.Entities.Exceptions; // importante classe que herda de das execeções da aplicação

namespace ExerTratamentoExcecoes.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;

        }

        public void Deposit(double amount)
        {
            Balance = amount;
        }

        public void Withdraw(double amount) // saque
        {
            if (amount > WithDrawLimit)
            {
                throw new DomainException("Withdraw error: The amount exceed withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainException("Withdraw error: Not enough balance");
            }
            
            Balance -= amount;
            
        }




    }
}
