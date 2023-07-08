class Band
{
    public string Name { get; }

    private List<Album> album = new List<Album>();

    public Band(string name)
    {
        this.Name = name;
    }

    public void AddAlbum (Album album)
    {
        this.album.Add(album);
    }

    public void Discography()
    {
        Console.WriteLine($"Discografia da banda {Name}\n");
        album.ForEach(album => Console.WriteLine($"Álbum: {album.Name} ({album.DurationTotal} s)"));

    }
}