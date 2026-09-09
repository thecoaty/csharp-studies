using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ScreenSound_API.Modelos;

internal class MusicasFavoritas
{
    public string? Nome { get; set; }
    public List<Musica> listaDeMusicasFavoritas;

    public MusicasFavoritas(string nome)
    {
        Nome = nome;
        listaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        listaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as musicas favoritas -> {Nome} ");
        foreach(var musica in listaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = listaDeMusicasFavoritas
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo json foi criado com sucesso em {Path.GetFullPath(nomeDoArquivo)}");
    }
}
