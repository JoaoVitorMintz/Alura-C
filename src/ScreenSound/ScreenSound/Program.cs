Album queenAlbum = new Album();
queenAlbum.Nome = "A night at the opera"; 

Music musica1 = new Music();
musica1.Nome = "Love of my life";
musica1.Duracao = 210;

Music musica2 = new Music();
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracao = 354;

queenAlbum.AddMusic(musica1);
queenAlbum.AddMusic(musica2);

queenAlbum.ExibirMusicas();