using ScreenSound_API.Modelos;
using ScreenSound_API.Filtros;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(response);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(response)!;
        //musicas[1].ExibirDetalhesDaMusica();
        LinqFilter.FiltrarMusicasEmCSharp(musicas);
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusica(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Lil Peep");

        //var musicaFavoritasKelvin = new MusicasFavoritas("Kelvin");
        //musicaFavoritasKelvin.AdicionarMusicasFavoritas(musicas[1]);
        //musicaFavoritasKelvin.AdicionarMusicasFavoritas(musicas[2]);
        //musicaFavoritasKelvin.AdicionarMusicasFavoritas(musicas[3]);
        //musicaFavoritasKelvin.AdicionarMusicasFavoritas(musicas[4]);
        //musicaFavoritasKelvin.AdicionarMusicasFavoritas(musicas[5]);
        //musicaFavoritasKelvin.ExibirMusicasFavoritas();

        //musicaFavoritasKelvin.GerarArquivoJson();
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
    
}