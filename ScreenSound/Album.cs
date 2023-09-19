class Album
{
    public Album(String nome)
    {
        Nome = nome;
    }

    private List<Musica> musicas = new List<Musica>();
    public String Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica) 
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($"\nLista de músicas do album {Nome}:");
        foreach(var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }

        Console.WriteLine($"\nPara ouvir este album inteiro voce precisa de: {DuracaoTotal}\n");
    }
}