using System.Collections;
using Q15_MusicStoreAlbum;

ArrayList albums = new ArrayList();

albums.Add(new Album("Thriller"        , "Michael Jackson"));
albums.Add(new Album("Back in Black"   , "AC/DC"));
albums.Add(new Album("Hotel California", "Eagles"));
albums.Add(new Album("Rumours"         , "Fleetwood Mac"));

Console.WriteLine("All Albums :");
foreach(Album a in albums)
    Console.WriteLine("  " + a);

Console.WriteLine("\nTotal albums : " + albums.Count);

albums.RemoveAt(1);
Console.WriteLine("\nAfter removing index 1 :");
foreach(Album a in albums)
    Console.WriteLine("  " + a);
