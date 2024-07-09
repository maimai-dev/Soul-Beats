Banda redVelvet = new("Red Velvet");

Album albumDoRedVelvet = new("#Cookie Jar");

Musica musica1 = new(redVelvet, "#Cookie Jar")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new(redVelvet, "Aitai-tai")
{
    Duracao = 194,
    Disponivel = false,
};

Musica musica3 = new(redVelvet, "Cause it's you")
{
    Duracao = 179,
    Disponivel = true,
};

Musica musica4 = new(redVelvet, "Dumb Dumb")
{
    Duracao = 202,
    Disponivel = false,
};

Musica musica5 = new(redVelvet, "Russian Roulette")
{
    Duracao = 211,
    Disponivel = true,
};

Musica musica6 = new(redVelvet, "Red Flavor")
{
    Duracao = 191,
    Disponivel = false,
};

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica3.ExibirFichaTecnica();
musica4.ExibirFichaTecnica();
musica5.ExibirFichaTecnica();
musica6.ExibirFichaTecnica();

albumDoRedVelvet.AdicionarMusica(musica1);
albumDoRedVelvet.AdicionarMusica(musica2);
albumDoRedVelvet.AdicionarMusica(musica3);
albumDoRedVelvet.AdicionarMusica(musica4);
albumDoRedVelvet.AdicionarMusica(musica5);
albumDoRedVelvet.AdicionarMusica(musica6);

albumDoRedVelvet.ExibirMusicasDoAlbum();
redVelvet.AdicionarAlbum(albumDoRedVelvet);
redVelvet.ExibirDiscografia();

Episodio ep1 = new("Apple Intelligence, IA tutora, Luma Dream Machine", 1, 3360);
ep1.AdicionarConvidados("Maiara");
ep1.AdicionarConvidados("Marcela");
ep1.AdicionarConvidados("Andreia");
Episodio ep2 = new("Google Gemini e Imersão Inteligência Artificial", 2, 3060);
ep2.AdicionarConvidados("Maiara");
ep2.AdicionarConvidados("Gustavo");
ep2.AdicionarConvidados("Danilo");
Episodio ep3 = new("Ecossistema WordPress", 3, 2520);
ep3.AdicionarConvidados("Marcela");
ep3.AdicionarConvidados("Erica");
ep3.AdicionarConvidados("Carla");

Podcast PodcastAlura = new("Alura", "Hipsters Ponto Tech");
PodcastAlura.AdicionarEpisodio(ep1);
PodcastAlura.AdicionarEpisodio(ep2);
PodcastAlura.AdicionarEpisodio(ep3);
PodcastAlura.ExibirDetalhes();



