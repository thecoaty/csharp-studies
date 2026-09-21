/*
Seja um aplicativo de gerenciamento de músicas onde os usuários podem organizar suas faixas
favoritas em playlists personalizadas. Para cada playlist, é essencial que o usuário tenha
controle total sobre a sequência de reprodução das músicas, permitindo reordená-las
livremente a qualquer momento. Além disso, o aplicativo precisa oferecer a funcionalidade de
reprodução aleatória para uma playlist específica, proporcionando uma experiência de audição
dinâmica e variada, sem, contudo, alterar a ordem original que o usuário definiu. O desafio
é criar uma estrutura robusta que suporte a adição e remoção eficiente de músicas, a
reordenação flexível dentro das playlists e a seleção de faixas tanto em modo sequencial
quanto aleatório.


 Funcoes que vamos implementar:
// [X] Criar as classes para musicas e playlist
// [X] Listar musicas da playlist
// [X] Adicionar musica à playlist
// [X] Obter uma musica especifica da playlist
// [X] Remover musica da playlist
// [X] Tocar uma musica aleatoria da playlist
// [X] Reordenar musicas segundo alguma logica especifica (ex. duracao)
// [X] Uma playlist nao pode ter musicas repetidas
// [ ] Exibir as 10 musicas mais tocadas em todas as playlists (ranking)
// [ ] Player de musica com:
// [ ] - Fila de reproducao (para musicas avulsas e/ou playlists)
// [ ] - Historico de reproducao

*/


using System.Collections;

namespace OperacoesEmColecoes;

internal class Program
{
    static void Main()
    {
        var musica1 = new Musica { Titulo = "Save that shit", Artista= "Lil Peep", Duracao = 455};
        var musica2 = new Musica { Titulo = "The brightside", Artista= "Lil Peep", Duracao = 200};
        var musica6 = new Musica { Titulo = "switch up", Artista= "Lil Peep", Duracao = 114};
        var musica3 = new Musica { Titulo = "Greygoose", Artista= "Yung Lean", Duracao = 120};
        var musica4 = new Musica { Titulo = "STORM II", Artista= "Yung Lean", Duracao = 240};
        var musica5 = new Musica { Titulo = "STORM II", Artista= "Yung Lean", Duracao = 240};

        var Alt = new Playlist { Nome = "Alt" };
        Alt.Add(musica1);
        Alt.Add(musica3);
        Alt.Add(musica2);
        Alt.Add(musica4);
        Alt.Add(musica5);
        Alt.Add(musica6);
        ExibirPlaylist(Alt);


        var lilPeep = new Playlist() { Nome = "Only Lil Peep" };
        lilPeep.Add(musica1);
        lilPeep.Add(musica2);
        lilPeep.Add(musica6);
        ExibirPlaylist(lilPeep);

        ExibirMaisTocadas(Alt, lilPeep);


        void ExibirPlaylist(Playlist playlist)
        {
            Console.WriteLine($"\nTocando as músicas de {playlist.Nome}");

            foreach (var musica in playlist)
            {
                Console.WriteLine($"\t - {musica.Titulo} ({musica.Artista}) - {musica.Duracao} segundos");
            }
        }

        void ExibirMaisTocadas(Playlist p1, Playlist p2)
        {
            Dictionary<Musica, int> ranking = [];

            foreach (var musica in p1){
                ranking.Add(musica, 1);
            }
            foreach(var musica in p2){
                if( ranking.TryGetValue(musica, out int contagem))
                {
                    contagem++;
                    ranking[musica] = contagem;
                }
                else{
                    ranking[musica] = 1;
                }
            }

            List<KeyValuePair<Musica, int>> top = [..ranking];

            top.Sort(new PorContagem());

            Console.WriteLine($"\nTop 3 músicas mais tocadas: \n");
            int contador = 1;
            foreach(var par in top){
                Console.WriteLine($"\t - {par.Key.Titulo}");
                contador++;
                if (contador > 3) break;
            }
        }

        void RemoverMusicaPeloTitulo(Playlist playlist, string titulo)
        {
            var musicaEncontrada = playlist.ObterPeloTitulo(titulo);
            if (musicaEncontrada is not null)
            {
                Console.WriteLine("\nRemovendo música...");
                playlist.Remove(musicaEncontrada);
            }
            else
            {
                Console.WriteLine("\nMúsica não encontrada.");
            }

            ExibirPlaylist(playlist);
        }

        void ExibirMusicaAleatoria(Playlist playlist)
        {
            var musicaAleatoria = playlist.ObterAleatoria();

            if (musicaAleatoria is not null)
            {
                Console.WriteLine($"\nA música aleatoria é {musicaAleatoria.Titulo}");
            }
            else
            {
                Console.WriteLine("\nPlaylist vazia!");
            }
        }

    }


class PorArtista : IComparer<Musica>
{ 
    public int Compare(Musica? x, Musica? y)
    {
            if (x is null || y is null) return 0;
            if (x is null) return 1;
            if (y is null) return -1;
            return x.Artista.CompareTo(y.Artista);
    }
}

class PorTitulo : IComparer<Musica>
{
    public int Compare(Musica? x, Musica? y)
    {
        if (x is null || y is null) return 0;
        if (x is null) return 1;
        if (y is null) return -1;
        return x.Titulo.CompareTo(y.Titulo);
    }
}

class PorContagem : IComparer<KeyValuePair<Musica, int>>
{
    public int Compare(KeyValuePair<Musica, int> x, KeyValuePair<Musica, int> y)
        { 
            return y.Value.CompareTo(x.Value);
        }
}

class Musica : IComparable
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; } 

    public int CompareTo(object? other)
    {
            if (other is null) return -1;
            if (other is Musica outraMusica) return this.Duracao.CompareTo(outraMusica.Duracao);
            return -1;
    }


        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (obj is Musica outraMusica) return this.Titulo.Equals(outraMusica.Titulo) && this.Artista.Equals(outraMusica.Artista);

            return false;

        }

        public override int GetHashCode()
        {
            return this.Titulo.GetHashCode() ^ this.Artista.GetHashCode();
        }
}

class Playlist : ICollection<Musica>
{
    private HashSet<Musica> set = [];
    private List<Musica> lista = [];

    public string Nome { get; set; }

    public int Count => lista.Count;

    public bool IsReadOnly => false;

    public void Add(Musica musica)
    {
        if(set.Add(musica))
        {
            lista.Add(musica);
        }
        
    }

    public void Clear()
    {
        lista.Clear();
    }

    public bool Contains(Musica item)
    {
        return lista.Contains(item);
    }
    
    public Musica? ObterPeloTitulo(string titulo)
    {
        foreach (var musica in lista)
        {
            if (musica.Titulo == titulo) return musica;
        }
        return null;
    }

    public Musica? ObterAleatoria()
    {
        if (lista.Count == 0) return null;
        var random = new Random();
        var indiceAleatorio = random.Next(0, lista.Count - 1);
        return lista[indiceAleatorio];
        
    }

    public void OrdenarPorDuracao(){
        lista.Sort();
    }

    public void OrdenarPorArtista(){
        lista.Sort(new PorArtista());
    }

    public void CopyTo(Musica[] array, int arrayIndex)
    {
        lista.CopyTo(array, arrayIndex);
    }

    public IEnumerator<Musica> GetEnumerator()
    {
        return lista.GetEnumerator();
    }

    public bool Remove(Musica item)
    {
        return (lista.Remove(item));
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
}