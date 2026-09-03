using System;
using System.Collections.Generic;
using System.Text;

namespace praticandoHeranca
{
    internal class Interno: Funcionario
    {
        public decimal Salario { get; }

        public Interno(string nome, string cargo, decimal salario) : base(nome,cargo) {
            this.Salario = salario;
        }
    }
}
