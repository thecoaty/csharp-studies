using System;
using System.Collections.Generic;
using System.Text;

namespace praticandoHeranca
{
    internal class Freelancer : Funcionario
    {
        public decimal ValorProjeto { get; }

        public Freelancer(string nome, string cargo, decimal valor): base(nome, cargo)
        {
            this.ValorProjeto = valor;
        }
        
    }
}
