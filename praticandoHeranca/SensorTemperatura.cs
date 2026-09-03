using System;
using System.Collections.Generic;
using System.Text;

namespace praticandoHeranca
{
    internal class SensorTemperatura : ISensor
    {
        public void Ativar()
        {
            Console.WriteLine("Sensor de temperatura ativado.");
        }
        public void Desativar()
        {
            Console.WriteLine("Sensor de temperatura Desativado.");
        }
    }
}
