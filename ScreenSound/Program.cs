Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Genero generoMusicas = new Genero("Rock");


Musica musica1 = new Musica(queen, "Love of my Life", "Rock")
{
    Duracao = 213,
    Disponivel = true
};


Musica musica2 = new Musica(queen, "Bohemian Rhapsody", "Rock")
{
    Duracao = 354,
    Disponivel = false
};



albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);


musica1.ExibirFicha();
musica2.ExibirFicha();
queen.ExibirDiscografia();


albumDoQueen.ExibirMusicasAlbum();
generoMusicas.ExibirGenero();



// Pratica sobre lambda 
//List<int> numeros = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

//List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);

//numerosPares.ForEach(numero => Console.WriteLine(numero));
