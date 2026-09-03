using System;
using System.Collections.Generic;
using System.Text;

namespace praticandoHeranca
{
    internal class Funcionario
    {
        public string Nome { get; }
        public string Cargo { get; }

        public Funcionario(string nome, string cargo)
        {
            this.Nome = nome;
            this.Cargo = cargo;
        }
    }
}
