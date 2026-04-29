class Filme
{
    public Filme (string titulo, int classificacaoetaria)
    {
        Titulo = titulo;
        classificacaoetaria = ClassificacaoEtaria;
    }

    public string Titulo {  get; set; }
    public int ClassificacaoEtaria { get; set; }
    public bool PodeAssistir(int idadeUsuario)
    {
        return idadeUsuario >= ClassificacaoEtaria;
    }
    public void ExibirResultado(int idadeUsuario)
    {
        if(PodeAssistir(idadeUsuario))
        {
           Console.WriteLine("Usuário com " + idadeUsuario + " anos pode assistir ao filme " + Titulo + ".");
        }
        else
        {
           Console.WriteLine("Usuário com " + idadeUsuario + " anos não pode assistir ao filme " + Titulo + ".");
        }
    }
}