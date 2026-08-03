namespace Q15_MusicStoreAlbum;

public class Album
{
    public string title;
    public string artist;

    public Album(string t , string a)
    {
        title  = t;
        artist = a;
    }

    public override string ToString()
    {
        return $"Title: {title} | Artist: {artist}";
    }
}
