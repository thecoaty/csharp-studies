using System;
using System.Collections.Generic;
using System.Text;

namespace praticandoHeranca
{
    internal class ClienteVip : Pessoa
    {

        public string nivelFidelidade { get; }

        public string codigoVip { get; }


        public ClienteVip(string nome, int idade, string NivelFidelidade, string CodigoVip) : base (nome, idade) { 
            this.nivelFidelidade = NivelFidelidade;
            this.codigoVip = CodigoVip;
        }

    }
}
