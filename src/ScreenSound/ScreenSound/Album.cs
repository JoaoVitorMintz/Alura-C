class Album
{
    private List<Music> musics = new List<Music>();
    public string Nome { get; set; }

    public int DuracaoTotal => musics.Sum(m => m.Duracao);
    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void ExibirMusicas()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var music in musics)
        {
            Console.WriteLine($"Música: {music.Nome}");
        }
        Console.WriteLine($"Tempo total do álbum: {DuracaoTotal} segundos");   
    }
}