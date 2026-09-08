using System;
using System.Collections.Generic;
using System.Text;

namespace praticandoPolimorfismo
{
    internal class Funcionario
    {
        public virtual string GerarRelatorio()
        {
           return "Relatório genérico do funcionário.";
        }
    }
}
