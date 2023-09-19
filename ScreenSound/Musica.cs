 class Musica
{
    public Musica(Banda artista, String nome, String genero) 
    {
        Artista = artista;
        Nome = nome;
        Genero = genero;
    }

    public String Nome { get; }

    public Banda Artista { get; }   

    public int Duracao { get; set; }

    public bool Disponivel { get; set; }

    public String Genero { get; }

    public String DescricaoBanda => $"A música {Nome} pertence a banda {Artista}";


    public void ExibirFicha()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duracao: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano.\n");
        }
        else
        {
            Console.WriteLine("Adquira o plano plus+.\n");
        }
    }

}

