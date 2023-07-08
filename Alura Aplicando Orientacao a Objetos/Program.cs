Band queen = new Band("Queen");

Music music1 = new Music(queen, "Bohemia Rhepyson")
{
    Duration = 230,
    Available = true
};

Music music2 = new Music(queen, "Love of my life")
{
    Duration = 180,
    Available = false
};

Album album1 = new Album("Bohemia");
album1.AddMusic(music1);
album1.AddMusic(music2);

album1.ListMusics();
Console.WriteLine($"Duracão Total: {album1.DurationTotal} segundos");

queen.AddAlbum(album1);
queen.Discography();

