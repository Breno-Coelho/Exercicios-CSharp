using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio07
{
    class Cliente
    {
        public string Nome { get; private set; }
        public string Conta { get; private set; }
        public float Saldo { get; private set; }

        /*Criando um Construtor com 3 parâmentros eu tiro a necessidede de criar um
        metodo para alterar a conta do cilente, uma vez que esta não deve ser alterada*/

        public Cliente( string Nome, string Conta, float Saldo)
        {
            this.Nome = Nome;
            this.Conta = Conta;
            this.Saldo = Saldo;
        }

        public Cliente() { }

        public Cliente(string nome, string conta)
        {
            Nome = nome;
            Conta = conta;
        }

        public void AlteraNome(string x)
        {
            Nome = x;
        }

        public void AlteraConta(string x)
        {
            Conta = x;
        }

        public void Deposito(float x)
        {
            Saldo += x;
        }

        public void Saque(float x)
        {
            Saldo -= x;
        }
    }
}
