using System;
using System.Collections.Generic;
using System.Text;

namespace praticandoHeranca
{
    internal class Pessoa
    {
        public string Nome { get;}
        public int Idade { get; }

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

    }
}
