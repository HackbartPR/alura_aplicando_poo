using System.Threading.Channels;

class Album
{
    private readonly List<Music> Musics = new List<Music>(); 

    public string Name { get; }

    public int DurationTotal 
    { 
        get
        {
            return Musics.Sum(music => music.Duration);
        }
    }

    public Album(string name)
    {
        this.Name = name;
    }

    public void AddMusic (Music music)
    {
        this.Musics.Add(music);
    }

    public void ListMusics()
    {
        Console.WriteLine($"Album: {this.Name}\n");
        this.Musics.ForEach(music => Console.WriteLine($"Música: {music.Name}"));
    }
}