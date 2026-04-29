class Produto
{
    public Produto(string nome, int quantidadeInicial)
    {
        Nome = nome;
        quantidadeEstoque = quantidadeInicial;
    }
    public string Nome {  get; set; }
    private int quantidadeEstoque;

    public void Retirar(int quantidade)
    {
        if (quantidade <= quantidadeEstoque)
        {
            quantidadeEstoque -= quantidade;
            Console.WriteLine($"Retirada de {quantidade} unidades realizada com sucesso.");
        }
        else
        {
            Console.WriteLine($"Produto: {Nome}");
            Console.WriteLine($"Erro: Estoque insuficiente para retirada de {quantidade} unidades.\n");
        }
    }

    public void ExibirEstoque()
    {
        Console.WriteLine($"Estoque: {quantidadeEstoque}");
    }

}