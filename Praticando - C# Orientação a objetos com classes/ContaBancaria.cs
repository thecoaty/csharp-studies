class ContaBancaria
{
    public ContaBancaria(string numeroconta, double saldo)
    {
        NumeroConta = numeroconta;
        Saldo = saldo;
    }
    public string NumeroConta { get; }
    public double Saldo { get; set; }

    public void Depositar(double valor)
    {
        Saldo += valor;
    }
}