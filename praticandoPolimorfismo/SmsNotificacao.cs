using System;
using System.Collections.Generic;
using System.Text;

namespace praticandoPolimorfismo
{
    internal class SmsNotificacao : INotificacao
    {
        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"Enviando SMS: {mensagem}");
        }
    }
}
