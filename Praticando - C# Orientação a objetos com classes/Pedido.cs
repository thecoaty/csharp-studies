class Pedido
{
    public Pedido(string numeroPedido, string nomeCliente)
    {
        NumeroPedido = numeroPedido;
        NomeCliente = nomeCliente;
        Status = "Pendente";
    }
    public string NumeroPedido { get; set; }
    public string NomeCliente { get; set; }
    public string Status {  get; set; }

    public void AtualizarStatus(string novoStatus)
    {
        Status = novoStatus;
    }
    public void ExibirPedido(){
        Console.WriteLine($"Pedido: {NumeroPedido}\n" +
            $"Cliente: {NomeCliente}\n" +
            $"Status: {Status}");
    }

}