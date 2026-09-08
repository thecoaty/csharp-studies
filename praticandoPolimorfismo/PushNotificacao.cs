using System;
using System.Collections.Generic;
using System.Text;

namespace praticandoPolimorfismo
{
    internal class PushNotificacao : INotificacao
    {
        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"Enviando PUSH: {mensagem}");
        }
    }
}
