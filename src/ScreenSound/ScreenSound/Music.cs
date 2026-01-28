class Music
{
    public string Nome {  get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel {  get; set; }
    public Genero Genero { get; set; }

    public string DescBanda => 
        $"A música {Nome} pertence à banda/artista {Artista}";


    public void ExibirFicha()
    {
        Console.WriteLine($"Nome: {Nome}\nArtista: {Artista}\nDuração: {Duracao} segundos");

        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano");
        } else
        {
            Console.WriteLine("Adquira o plano Plus");
        }
    }
}