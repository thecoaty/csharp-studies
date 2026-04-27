Livro meulivro = new Livro();
meulivro.Titulo = "Dom Casmurro";
meulivro.Autor = "Machado de Assis";

Console.WriteLine(
    $"Livro: {meulivro.Titulo} \n" +
    $"Autor: {meulivro.Autor}"
    );

Passagem lucas = new("Lucas Souza", "Paris");
Console.WriteLine(
    $"Passageiro: {lucas.Passageiro} \n" +
    $"Destino: {lucas.Destino}");

ContaBancaria conta = new("78901-2", 1000.00);
Console.WriteLine(
    $"Conta: {conta.NumeroConta}" +
    $"Saldo: {conta.Saldo}");
conta.Depositar(500.00);
Console.WriteLine(
    $"Conta: {conta.NumeroConta}" +
    $"Saldo: {conta.Saldo}");

Funcionario funcionario = new("Carlos Pereira", "Assistente Administrativo");
Console.WriteLine(
    $"Funcionario: {funcionario.Nome} \n" +
    $"Cargo atual: {funcionario.Cargo}");
funcionario.Promover("Assistente Administrativo");
funcionario.Promover("Analista de Projetos");
Console.WriteLine(
    $"Funcionario: {funcionario.Nome} \n" +
    $"Cargo atual: {funcionario.Cargo}");