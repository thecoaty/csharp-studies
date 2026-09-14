using ByteBankIO;
using System.Text;
partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456, 7895, 4785.40, Gustavo Luz";

            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(contaComoString);

            fluxoDeArquivo.Write(bytes, 0, bytes.Length);
        }
    }

    static void CriarArquivoComWriter()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";
        
        using(var fluxoDeArquivos = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using(var escritor = new StreamWriter(fluxoDeArquivos))
        {
            escritor.Write("123, 21421, 456.0, Pedro");
        }
    }

    static void TestaEscrita()
    {
        var caminhoNovoArquivo = "teste.txt";

        using (var fluxoDeArquivos = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivos))
        {
            for(int i = 0; i < 1000000; i++){
                escritor.WriteLine($"Linha {i}");
                escritor.Flush(); 
                Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter para continuar");
                Console.ReadLine();
            }
            
        }
    }

}