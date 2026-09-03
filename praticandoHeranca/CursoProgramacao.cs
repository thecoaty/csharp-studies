using System;
using System.Collections.Generic;
using System.Text;

namespace praticandoHeranca
{
    internal class CursoProgramacao : ICurso
    {
        private Instrutor Instrutor;
        private string Titulo;

        public CursoProgramacao(string titulo, Instrutor instrutor)
        {
            this.Instrutor = instrutor;
            this.Titulo = titulo;
        }

        public void ValidarConteudo()
        {
            Console.WriteLine($"Validando conteúdo do curso de programação: {this.Titulo}");
        }
        public void PublicarCurso()
        {
            Console.WriteLine($"Curso publicado com sucesso: {this.Titulo} - Instrutor(a): {this.Instrutor.Nome} ({this.Instrutor.Especialidade}) ");
        }
    }
}
