class Podcast
{
    private List<Episodios> episodios = new List<Episodios>();
    public Podcast(String host, String nome)
    {
        Host = host;
        Nome = nome;
    }

    public String Host { get; } 
    public String Nome { get; }

    public int TotalEpisodios { get; }

    public void AdicionarEpisodio(Episodios eps)
    {
        episodios.Add(eps);
    }

    public void ExibirDetalhes() 
    {
        
    }

}