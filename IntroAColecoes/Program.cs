
using System.Collections;

var diasDaSemana = new DiaDaSemana(); 

var carrinho = new List<Produto>{
new Produto() {Nome = "Leite", Preco = 7.89},
new Produto() {Nome = "Manteiga", Preco = 3.45}
};

void PercorrendoComForEach(){
    foreach(var produto in carrinho){
        Console.WriteLine($"Produto: {produto.Nome}");
    }
}

void PercorrendoDiasDaSemana(){
    foreach(var dia in diasDaSemana){
        Console.WriteLine(dia);
    }
}
class Produto{
    public string Nome { get; set; }
    public double Preco { get; set; }
}

class DiaDaSemana : IEnumerable<string>
{
    public IEnumerator<string> GetEnumerator()
    {
        yield return "Domingo";
        yield return "Segunda";
        yield return "Terça";
        yield return "Quarta";
        yield return "Quinta";
        yield return "Sexta";
        yield return "Sábado";

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}