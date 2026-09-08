using System;
using System.Collections.Generic;
using System.Text;

namespace praticandoPolimorfismo
{
    internal class Gerente : Funcionario
    {
        public override string GerarRelatorio()
        {
            return "Relatório do gerente: supervisiona a equipe.";
        }
    }
}
