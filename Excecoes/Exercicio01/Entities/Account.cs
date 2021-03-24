using System;
using System.Collections.Generic;
using System.Text;
using Exercicio01.Entities.Exceptions;

namespace Exercicio01.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public float Balance { get; set; }
        public float WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, float balance, float withdrawLimit)
        {
            if (balance < 0 || withdrawLimit < 0)
            {
                throw new DomainException("Valor de saldo ou limite negativo");
            }
            
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }


        public void Deposito(float x)
        {
            if (x < 5)
            {
                throw new DomainException(" Deposito com valor mixuruca");
            }
            
            Balance += x;
        }

        public void Saque(float x)
        {
            if (Balance == 0 || x > Balance || x > WithdrawLimit)
            {
                throw new DomainException("Valor de saque maior que o saldo");
            }

            Balance -= x;
        }
    }
}
