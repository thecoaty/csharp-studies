using System;
using System.Collections.Generic;
using System.Text;

namespace praticandoHeranca
{
    internal class SensorPresenca : ISensor
    {
        public void Ativar()
        {
            Console.WriteLine("Sensor de presença ativado.");
        }
        public void Desativar()
        {
            Console.WriteLine("Sensor de presença Desativado.");
        }
    }
}
