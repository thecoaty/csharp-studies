using System;
using System.Collections.Generic;
using System.Text;

namespace praticandoHeranca
{
    internal class Certificado
    {
        public Certificado(Profissao prof) {
            Console.WriteLine($"Certificado Emitido para: {prof.titulo}");
        }
    }
}
