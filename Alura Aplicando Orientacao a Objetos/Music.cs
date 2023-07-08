class Music
{
    public string Name { get;}
    public Band Artist { get; }
    public int Duration { get; set; }
    public bool Available { get; set; }

    public string FullName 
    {
        get
        {
            return $"A música {this.Name} pertence ao artista {this.Artist.Name}.";
        }
    }

    public Music(Band band, string name)
    {
        this.Artist = band;
        this.Name = name;
    }

    public void Informations () 
    {
        Console.WriteLine($"Nome: {this.Name}");
        Console.WriteLine($"Artista: {this.Artist}");
        Console.WriteLine($"Duração: {this.Duration}");
        
        string availability = this.Available ? "Está Disponível" : "Não está Disponível";
        Console.WriteLine(availability);
    }
}