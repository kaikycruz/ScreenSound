class Genero
{
    public Genero(String nome)
    {
        NomeGenero = nome;
    }

    private List<Musica> generos = new List<Musica>();
    public String NomeGenero { get; }

    public void AdicionandoGenero(Musica genero)
    {
        generos.Add(genero);
    }

    
    public void ExibirGenero()
    {
        Console.WriteLine($"As musicas do album tem o genero {NomeGenero}\n");
    }
}