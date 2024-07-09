class Podcast
{
    private List<Episodio> episodios = new();
    
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"\nPodcast {Nome} apresentado por {Host}");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine($"\n{episodio.Resumo}");
        }
        Console.WriteLine($"\nEste podcast possui {TotalEpisodios} episódios.");
    }

}

