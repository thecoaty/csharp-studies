class InformacaoTecnica
{
    public InformacaoTecnica(int tamanhoMB, string sistemaOperacional)
    {
        TamanhoMB = tamanhoMB;
        SistemaOperacional = sistemaOperacional;
    }
    public int TamanhoMB { get; set; }
    public string SistemaOperacional { get; set; }
}