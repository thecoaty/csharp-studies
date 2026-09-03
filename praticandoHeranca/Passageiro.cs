using System;
using System.Collections.Generic;
using System.Text;

namespace praticandoHeranca
{
    internal class Passageiro : Pessoa
    {
        public int QuatidadeBilhetes { get; }

        public Passageiro(string nome, int idade, int quantidadeBilhetes) : base(nome, idade)
        {
            this.QuatidadeBilhetes = quantidadeBilhetes;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Passageiro: {this.Nome} - Idade: {this.Idade} - Bilhetes: {this.QuatidadeBilhetes}");
        }
    }
}
