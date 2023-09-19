class Banda 
{
    public Banda(String nome)
    {
        Nome = nome;
    }

    private List<Album> albums = new List<Album>();      
    public String Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}:");
        foreach(Album album in albums)
        {
            Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal})\n");
        }
    }
}
