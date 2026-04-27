class Funcionario
{
    public Funcionario(string nome, string cargo)
    {
        Nome = nome;
        Cargo = cargo;
    }
    public string Nome { get; set; }
    public string Cargo { get; set; }

    public void Promover(string novoCargo)
    {
        if (novoCargo == Cargo)
        {
            Console.WriteLine("Tentativa Inválida");
        }
        else
        {
            Cargo = novoCargo;
            Console.WriteLine("Promoção realizada com sucesso!");
        }
    }
}