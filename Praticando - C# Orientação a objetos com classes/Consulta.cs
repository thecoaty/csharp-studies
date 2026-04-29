class Consulta
{
    public Consulta(string nomePaciente, string nomeMedico, DateTime dataConsulta)
    {
        NomePaciente = nomePaciente;
        NomeMedico = nomeMedico;
        DataConsulta = dataConsulta;
    }
    public string NomePaciente { get; set; }
    public string NomeMedico { get; set; }
    public DateTime DataConsulta { get; set; }

    public void Reagendar(DateTime novaData)
    {
        DataConsulta = novaData;
    }
    public void ExibirResumo()
    {
        Console.WriteLine($"\nPaciente: {NomePaciente}\n" +
            $"Médico: {NomeMedico}\n" +
            $"Data da Consulta: {DataConsulta}");
    }
}