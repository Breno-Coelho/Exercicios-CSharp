using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio05.Entities
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, string email, string cPF, int idade)
        {
            Nome = nome;
            Email = email;
            CPF = cPF;
            Idade = idade;
        }


        public override string ToString()
        {
            return $"Nome: {Nome, -30}| E-mail: {Email, -20}| CPF: {CPF, -12}| Idade: {Idade, -7}";
        }
    }
}
