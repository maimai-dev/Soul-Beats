class Episodio
{
    private List<string> convidados = new();
    public Episodio(string titulo, int ordem, int duracao)
    {
        Titulo = titulo;
        Ordem = ordem;
        Duracao = duracao;
    }

    public string Titulo { get; }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";
    public int Ordem { get; }
    public int Duracao { get; }
    
    

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}